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
    public partial class FormMenu : Form
    {
        private Usuario usuario;

        public FormMenu(Usuario usuarioLogueado)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lbUsuarioInfo.Text = $"Bienvenido, {usuario.Nombre} ({usuario.Rol})";
        }

        private void AgregarSocio_Click(object sender, EventArgs e)
        {
            FormAgregarSocio form = new FormAgregarSocio();
            form.ShowDialog();
        }

        private void AgregarNoSocio_Click(object sender, EventArgs e)
        {
            FormAgregarNoSocio form = new FormAgregarNoSocio();
            form.ShowDialog();
        }

        private void PagarCuota_Click(object sender, EventArgs e)
        {
            FrmPagoCuota form = new FrmPagoCuota();
            form.ShowDialog();
        }

        private void InscribirActividad_Click(object sender, EventArgs e)
        {
            FrmInscribirActividad form = new FrmInscribirActividad();
            form.ShowDialog();
        }

        private void btnClientesACobrar_Click(object sender, EventArgs e)
        {
            FormSociosACobrar frm = new FormSociosACobrar();
            frm.ShowDialog();
        }
    }
}
