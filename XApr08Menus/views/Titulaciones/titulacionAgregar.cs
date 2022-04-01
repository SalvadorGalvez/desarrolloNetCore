using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.Titulaciones
{
    public partial class titulacionAgregar : Form
    {
        private readonly int ID = 20;
        private UsuariosModel modelo;
        public titulacionAgregar(UsuariosModel modelo)
        {
            InitializeComponent();

            Querys q = new Querys();
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
