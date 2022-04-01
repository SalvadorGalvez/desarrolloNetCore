using System;
using System.Collections;
using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views.Usuarios
{
    public partial class usuariosDesactivar : Form
    {
        private readonly int ID = 11;
        private UsuariosModel modelo;
        private bool estado;

        public usuariosDesactivar()
        {
            InitializeComponent();
            Querys.llenarCombo(cmbUsr, btnUsr,6, new ArrayList(), false);
        }

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            
            try
            {
                Querys.BorrarUsuario(7,cmbUsr.SelectedValue.ToString(), "admin");
                MessageBox.Show("El usuario " + cmbUsr.Text + " ha sido borrado");
                Querys.llenarCombo(cmbUsr, btnUsr, 6, new ArrayList(), false);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            groupBox1.Visible = false;
        }

        private void btnUsr_Click(object sender, System.EventArgs e)
        {
            groupBox1.Visible = true;
            try
            {
                estado = Querys.estadoUsuario(cmbUsr.SelectedValue.ToString());
                if (estado)
                {
                    btnActivar.Text = "Desactivar usuario";
                } else
                {
                    btnActivar.Text = "Activar usuario";
                }
            } catch (Exception ex)
            {
                groupBox1.Visible = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActivar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (estado)
                {
                    Querys.cambiarEstadoUsuario(false,cmbUsr.SelectedValue.ToString(), "admin");
                    btnActivar.Text = "Activar usuario";
                    estado = false;
                } else
                {
                    Querys.cambiarEstadoUsuario(true, cmbUsr.SelectedValue.ToString(), "admin");
                    btnActivar.Text = "Desactivar usuario";
                    estado = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                groupBox1.Visible=false;
            }
        }

        /*
        public usuariosDesactivar(UsuariosModel modelo)
        {
            
            if (!Querys.tienePermiso(modelo.Tipo, ID))
            {
                MessageBox.Show(Properties.Resources.sinPermiso);
                this.Close();
            }
            else
            {
                this.Show();
            }
        }*/
    }
}
