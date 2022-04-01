using System;
using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.Actas
{
    public partial class actasVisualizar : Form
    {
        private readonly int ID = 2;
        private UsuariosModel modelo;
        public actasVisualizar(UsuariosModel modelo)
        {
            InitializeComponent();
            if (!Querys.tienePermiso(modelo.Tipo, ID))
            {
                MessageBox.Show(Properties.Resources.sinPermiso);
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void actasVisualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
