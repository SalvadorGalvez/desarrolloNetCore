using System;
using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.Usuarios
{
    public partial class usuariosAgregar : Form
    {
        private readonly int ID = 9;
        private UsuariosModel modelo;

        public usuariosAgregar(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            if (!Querys.tienePermiso(modelo.Tipo, ID))
            {
                MessageBox.Show(Properties.Resources.sinPermiso);
                this.Close();
            }
            else
            {
                this.Show();
            }

            Querys.llenarTipo(comboBox1);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escribe el nombre...");
                txtName.Focus();
            } else if (txtUsr.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escribe el usuario...");
                txtUsr.Focus();
            }
            else if (txtClave.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escribe la clave...");
                txtClave.Focus();
            } else
            {
                try
                {
                    Querys.agregarUsuario(txtUsr.Text,txtName.Text,txtClave.Text,""+comboBox1.SelectedValue, modelo.Usuario);
                    MessageBox.Show("Usuario ["+txtName.Text+"] agregardo correctamente");
                    txtUsr.Text = String.Empty;
                    txtName.Text = String.Empty;
                    txtClave.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            txtClave.PasswordChar = '*';
        }
    }
}
