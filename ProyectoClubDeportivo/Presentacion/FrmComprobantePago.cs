using Mysqlx.Cursor;
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
    public partial class FrmComprobantePago : Form
    {
        public FrmComprobantePago(string nombreCliente, string nombreActividad, DateTime fecha, string formaPago, decimal monto)
        {
            InitializeComponent();
            lblFecha.Text += fecha.ToString("dd/MM/yyyy");
            lblCliente.Text += nombreCliente;
            lblActividad.Text += nombreActividad;
            lblFormaPago.Text += formaPago;
            lblMonto.Text += monto.ToString("F2");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmComprobantePago_Load(object sender, EventArgs e)
        {

        }
    }
}
