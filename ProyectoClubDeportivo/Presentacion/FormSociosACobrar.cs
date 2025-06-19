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
    public partial class FormSociosACobrar : Form
    {
        public FormSociosACobrar()
        {
            InitializeComponent();
            this.Load += FormSociosACobrar_Load;
        }

        private void FormSociosACobrar_Load(object sender, EventArgs e)
        {
            CargarSociosACobrar();
        }

        private void CargarSociosACobrar()
        {
            try
            {
                List<Socio> socios = SocioDAO.ObtenerSociosACobrarHoy();
                if (socios.Count == 0)
                {
                    DataTable tabla = new DataTable();
                    tabla.Columns.Add("Mensaje", typeof(string));

                    DataRow fila = tabla.NewRow();
                    fila["Mensaje"] = "Sin datos";
                    tabla.Rows.Add(fila);

                    dgvSociosACobrar.DataSource = tabla;
                    dgvSociosACobrar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvSociosACobrar.DataSource = socios;
                    dgvSociosACobrar.Columns[0].Visible = false;
                    dgvSociosACobrar.Columns[1].Visible = false;
                    dgvSociosACobrar.Columns[8].Visible = false;
                    dgvSociosACobrar.Columns[9].Visible = false;
                    dgvSociosACobrar.ClearSelection();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los socios: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
