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
    public partial class FrmInscribirActividad : Form
    {
        public FrmInscribirActividad()
        {
            InitializeComponent();
        }

        private void FrmInscribirActividad_Load(object sender, EventArgs e)
        {
            ActividadDAO dao = new ActividadDAO();
            dgvActividades.DataSource = dao.ObtenerActividades(); 
            dgvActividades.Columns["Id"].HeaderText = "Código";
            dgvActividades.Columns["Nombre"].HeaderText = "Actividad";
            dgvActividades.Columns["Precio"].HeaderText = "Precio ($)";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (dgvActividades.CurrentRow != null)
            {
                long idActividad = Convert.ToInt64(dgvActividades.CurrentRow.Cells["Id"].Value);
                string nombreActividad = dgvActividades.CurrentRow.Cells["Nombre"].Value.ToString();
                decimal precioActividad = Convert.ToDecimal(dgvActividades.CurrentRow.Cells["Precio"].Value);

                FrmInscribirCliente frmCliente = new FrmInscribirCliente(idActividad, nombreActividad, precioActividad);
                frmCliente.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una actividad primero.");
            }
        }

        private void btnGridVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
