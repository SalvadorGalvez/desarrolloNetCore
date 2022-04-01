using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.LugaresTitulacion
{
    public partial class lugarAgregar : Form
    {
        private readonly int ID = 5;
        private UsuariosModel modelo;
        public lugarAgregar(UsuariosModel modelo)
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
