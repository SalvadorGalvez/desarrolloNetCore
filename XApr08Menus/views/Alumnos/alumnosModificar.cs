using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.Alumnos
{
    public partial class alumnosModificar : Form
    {
        private readonly int ID = 4;
        private UsuariosModel modelo;
        public alumnosModificar(UsuariosModel modelo)
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
