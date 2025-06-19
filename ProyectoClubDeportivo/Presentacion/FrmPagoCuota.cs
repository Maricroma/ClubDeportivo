using ProyectoClubDeportivo.Datos;
using ProyectoClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClubDeportivo.Presentacion
{
    public partial class FrmPagoCuota : Form
    {
        private Cliente? cliente;
        private long cuotaId;
        private DateTime proximoPago;

        public FrmPagoCuota()
        {
            InitializeComponent();
        }

        private void FrmPagoCuota_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            string dni = tbBuscarDni.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cliente = ClienteDAO.BuscarPorDni(dni);

            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (cliente is Socio socio)
            {
                gbDatosCliente.Visible = true;
                lblNombre.Text = $"Socio: {socio.Nombre} {socio.Apellido}";
                proximoPago = socio.FechaProximoPago;
                lblProximoPago.Text = "Fecha de vencimiento: " + proximoPago.ToString("dd/MM/yyyy");
                gpDatosPago.Visible = true;
                btnPagar.Visible = true;
                btnPagar.Enabled = false;
                btnImprimirCuota.Visible = true;
                btnImprimirCuota.Enabled = false;
            }
            else if (cliente is NoSocio)
            {
                MessageBox.Show("Cliente no socio. No abona cuotas.", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
        }

        private void tbImporte_TextChanged(object sender, EventArgs e)
        {
            // Habilitar el botón de pagar solo si se ha ingresado un importe válido
            if (decimal.TryParse(tbImporte.Text, out decimal precio) && precio > 0)
            {
                btnPagar.Enabled = true;
            }
            else
            {
                btnPagar.Enabled = false;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                MessageBox.Show("No se ha seleccionado un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rbEfectivo.Checked && !rbTarjeta.Checked)
            {
                MessageBox.Show("Debe seleccionar un método de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar precio ingresado
            if (string.IsNullOrWhiteSpace(tbImporte.Text))
            {
                MessageBox.Show("Debe ingresar un importe.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tbImporte.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El importe debe ser un número positivo válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formaPago = rbEfectivo.Checked ? "Efectivo" : "Tarjeta";

            // Registrar el pago
            cuotaId = CuotaDAO.InsertarPagoCuota(cliente.Id, DateTime.Today, precio, formaPago);
            proximoPago = proximoPago.AddMonths(1);
            SocioDAO.ActualizarFechaProximoPago(cliente.Id, proximoPago);

            MessageBox.Show($"Pago registrado correctamente.\nForma de pago: {formaPago}\nImporte: {precio:C}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnImprimirCuota.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cliente == null || cuotaId == 0)
            {
                MessageBox.Show("Debe registrar un pago antes de imprimir.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formaPago = rbEfectivo.Checked ? "Efectivo" : "Tarjeta";

            if (!decimal.TryParse(tbImporte.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El importe debe ser un número positivo válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmComprobantePago comprobante = new FrmComprobantePago(
                cliente.Nombre + " " + cliente.Apellido,
                "Cuota Mensual - Próx. Vencimiento: " + proximoPago.ToString("dd/MM/yyyy"),
                DateTime.Now,
                formaPago,
                precio
            );

            comprobante.ShowDialog();

            RecargarFormulario();
         
        }

        private void RecargarFormulario()
        {
            cliente = null;
            cuotaId = 0;
            proximoPago = DateTime.MinValue;

            tbBuscarDni.Clear();
            tbImporte.Clear();
            rbEfectivo.Checked = false;
            rbTarjeta.Checked = false;

            gbDatosCliente.Visible = false;
            gpDatosPago.Visible = false;
            btnPagar.Visible = false;
            btnPagar.Enabled = false;
            btnImprimirCuota.Visible = false;
            btnImprimirCuota.Enabled = false;

            tbBuscarDni.Focus();
        }
    }
}
