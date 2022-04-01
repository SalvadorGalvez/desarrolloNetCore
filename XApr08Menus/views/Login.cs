using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsr_TextChanged(object sender, EventArgs e)
        {
            if (txtUsr.Text.Trim() != String.Empty)
            {
                txtUsr.ForeColor = Color.Black;
            } else
            {
                txtUsr.ForeColor = Color.LightGray;
            }
        }

        private void txtUsr_Enter(object sender, EventArgs e)
        {
            if (txtUsr.Text == Properties.Resources.LoginUsr)
            {
                txtUsr.Text = String.Empty;
            }
        }

        private void txtUsr_Leave(object sender, EventArgs e)
        {
            if (txtUsr.Text.Trim() == String.Empty)
            {
                txtUsr.Text = Properties.Resources.LoginUsr;
                txtUsr.ForeColor = Color.LightGray;
            }
        }

        private void txtClv_Enter(object sender, EventArgs e)
        {
            if (txtClv.Text == Properties.Resources.LoginClv)
            {
                txtClv.Text = String.Empty;
                txtClv.PasswordChar = '*';
            }
        }

        private void txtClv_Leave(object sender, EventArgs e)
        {
            if (txtClv.Text.Trim() == String.Empty)
            {
                txtClv.Text = Properties.Resources.LoginClv;
                txtClv.ForeColor = Color.LightGray;
                txtClv.PasswordChar= '\0';
            }
        }

        private void txtClv_TextChanged(object sender, EventArgs e)
        {
            if (txtClv.Text.Trim() != String.Empty)
            {
                txtClv.ForeColor = Color.Black;
                txtClv.PasswordChar = '*';
            } else
            {
                txtClv.ForeColor= Color.LightGray;
                txtClv.PasswordChar= '\0';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsr.ForeColor == Color.LightGray)
            {
                MessageBox.Show(Properties.Resources.LoginUsr);
                txtUsr.Focus();

            } else if (txtUsr.Text.Trim() == String.Empty)
            {
                MessageBox.Show(Properties.Resources.LoginUsr);
                txtUsr.Focus();

            } else if (txtClv.ForeColor == Color.LightGray)
            {
                MessageBox.Show(Properties.Resources.LoginClv);
                txtUsr.Focus();

            } else if (txtClv.Text.Trim() == String.Empty)
            {
                MessageBox.Show(Properties.Resources.LoginClv);
                txtUsr.Focus();
            } else
            {
                try
                {
                    UsuariosModel usr = Querys.buscarUsuarios(txtUsr.Text,txtClv.Text);
                    MessageBox.Show("Bienvenido: " + usr.Nombre);
                    this.Hide();
                    Principal frm = new Principal(usr);
                    frm.Show();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
