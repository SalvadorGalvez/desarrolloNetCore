using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.LugaresTitulacion
{
    public partial class lugarModificar : Form
    {
        private readonly int ID = 6;
        private UsuariosModel modelo;
        public lugarModificar(UsuariosModel modelo)
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
    }
}
