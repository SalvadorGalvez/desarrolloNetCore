using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.Directivos
{
    public partial class directivosAgregar : Form
    {
        private readonly int ID = 14;
        private UsuariosModel modelo;
        public directivosAgregar(UsuariosModel modelo)
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
