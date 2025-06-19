using MySqlX.XDevAPI;
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
    public partial class FrmInscribirCliente : Form
    {
        private Cliente? cliente;
        private long? idPagoActividad;

        public FrmInscribirCliente()
        {
            InitializeComponent();
        }

        private void FrmInscribirCliente_Load(object sender, EventArgs e)
        {
            lblActividad.Text = $"Actividad seleccionada: {nombreActividad}";
            btnConfirmarSocio.Visible = false;
            btnPagar.Visible = false;
            btnImprimirNoSocio.Visible = false;
            gbFormaPago.Visible = false;
            lblNombreCliente.Visible = false;
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            lblNombreCliente.Visible = false;
            string dni = tbBuscarDni.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cliente = ClienteDAO.BuscarPorDni(dni);

            btnConfirmarSocio.Visible = false;
            btnPagar.Visible = false;
            btnImprimirNoSocio.Visible = false;
            lblSocioEstado.Text = string.Empty;
            lblSocioEstado.Visible = false;
            gbFormaPago.Visible = false;

            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (!cliente.FichaMedica)
            {
                MessageBox.Show("Cliente no presentó ficha médica. No puede inscribirse.", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (cliente is Socio socio)
            {
                lblSocioEstado.Visible = true;
                lblNombreCliente.Text = "Cliente: " + cliente.Nombre + " " + cliente.Apellido;
                lblNombreCliente.Visible = true;

                if (socio.FechaProximoPago >= DateTime.Today)
                {
                    lblSocioEstado.Text = "Cuota al día.";
                    btnConfirmarSocio.Enabled = true;
                    btnConfirmarSocio.Visible = true;
                }
                else
                {
                    lblSocioEstado.Text = "La cuota está vencida.";
                    btnConfirmarSocio.Enabled = false;
                    MessageBox.Show("El socio no está al día con la cuota.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else if (cliente is NoSocio)
            {
                lblNombreCliente.Text = "Cliente: " + cliente.Nombre + " " + cliente.Apellido;
                lblNombreCliente.Visible = true;
                btnImprimirNoSocio.Visible = true;
                btnImprimirNoSocio.Enabled = false;
                lblSocioEstado.Text = string.Empty;
                lblSocioEstado.Visible = false;
                btnPagar.Visible = true;
                btnPagar.Enabled = false;
                gbFormaPago.Visible = true;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                MessageBox.Show("Debe buscar un cliente antes de realizar un pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            { 
                idPagoActividad = PagoActividadDAO.InsertarPagoActividad(cliente.Id, DateTime.Now, idActividad);

                MessageBox.Show("Pago registrado correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btnImprimirNoSocio.Enabled = true;
                btnPagar.Enabled = false;
                gbFormaPago.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaPago_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked || rbTarjeta.Checked)
            {
                btnPagar.Enabled = true;
            }
        }

        private void btnImprimirNoSocio_Click(object sender, EventArgs e)
        {
            if (cliente == null || idPagoActividad == 0)
            {
                MessageBox.Show("Debe registrar un pago antes de imprimir.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idPagoActividad == null)
            {
                MessageBox.Show("No se encontró el pago.", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            string formaPago = rbEfectivo.Checked ? "Efectivo" : "Tarjeta";

            FrmComprobantePago comprobante = new FrmComprobantePago(
                cliente.Nombre + " " + cliente.Apellido,
                nombreActividad,
                DateTime.Now,
                formaPago,
                precioActividad
            );

            comprobante.ShowDialog();

            lblNombreCliente.Visible = false;
            lblNombreCliente.Text = string.Empty;
            tbBuscarDni.Clear();
            tbBuscarDni.Focus();
            lblSocioEstado.Visible = false;
            lblSocioEstado.Text = string.Empty;
        }

        private void btnConfirmarSocio_Click(object sender, EventArgs e)
        {
            idPagoActividad = PagoActividadDAO.InsertarPagoActividad(cliente.Id, DateTime.Now, idActividad);

            FrmComprobantePago comprobante = new FrmComprobantePago(
                cliente.Nombre + " " + cliente.Apellido,
                nombreActividad,
                DateTime.Now,
                "NA",
                0
            );

            comprobante.ShowDialog();

            lblNombreCliente.Visible = false;
            lblNombreCliente.Text = string.Empty;
            tbBuscarDni.Clear();
            tbBuscarDni.Focus();
            lblSocioEstado.Visible = false;
            lblSocioEstado.Text = string.Empty;

        }
    }
}
