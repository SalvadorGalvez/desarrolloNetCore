using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.Bitacora
{
    public partial class bitacoraConsulta : Form
    {
        private readonly int ID = 12;
        private UsuariosModel modelo;
        public bitacoraConsulta(UsuariosModel modelo)
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
