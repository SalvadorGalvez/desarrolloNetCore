using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.Departamentos
{
    public partial class departamentosModificar : Form
    {
        private readonly int ID = 17;
        private UsuariosModel modelo;
        public departamentosModificar(UsuariosModel modelo)
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
