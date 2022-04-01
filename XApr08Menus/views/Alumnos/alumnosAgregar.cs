using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.Alumnos
{
    public partial class alumnosAgregar : Form
    {
        private readonly int ID = 3;
        private UsuariosModel modelo;
        public alumnosAgregar(UsuariosModel modelo)
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
