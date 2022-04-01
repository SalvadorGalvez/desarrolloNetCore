using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.Usuarios
{
    public partial class usuariosDesactivar : Form
    {
        private readonly int ID = 11;
        private UsuariosModel modelo;
        public usuariosDesactivar(UsuariosModel modelo)
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
