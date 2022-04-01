using System;
using System.Windows.Forms;
using XApr08Menus.Models;
using XApr08Menus.Utilerias;

namespace XApr08Menus
{
    public partial class Principal : Form
    {
        private UsuariosModel modelo;
        public Principal(UsuariosModel modelo)
        {
            InitializeComponent();

            
            this.modelo = modelo;
            this.Text = this.Text + " - " + this.modelo.Nombre;

            titulacionesToolStripMenuItem.Visible = false;

            datosInstitucionalesToolStripMenuItem.Visible = false;
            modificarInstitucionToolStripMenuItem.Visible = false;
            directivosToolStripMenuItem.Visible = false;
            departamentosToolStripMenuItem.Visible = false;
            carrerasToolStripMenuItem.Visible = false;

            bitacoraToolStripMenuItem.Visible = false;
            actasToolStripMenuItem.Visible = false;
            firmarToolStripMenuItem.Visible = false;
            alumnosToolStripMenuItem.Visible = false;
            lugaresDeTitulacionToolStripMenuItem.Visible = false;
            profesoresToolStripMenuItem.Visible = false;
            usuariosToolStripMenuItem.Visible = false;

            if (this.modelo.Tipo == 0)
            {
                lugaresDeTitulacionToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible=true;
                datosInstitucionalesToolStripMenuItem.Visible = true;
                directivosToolStripMenuItem.Visible = true;
                modificarInstitucionToolStripMenuItem.Visible = true;
                bitacoraToolStripMenuItem.Visible = true;
            }
            else if (this.modelo.Tipo == 1)
            {
                actasToolStripMenuItem.Visible = true;
                firmarToolStripMenuItem.Visible = true;
                lugaresDeTitulacionToolStripMenuItem.Visible = true;
                titulacionesToolStripMenuItem.Visible = true;
            }
            else if (this.modelo.Tipo == 2)
            {
                actasToolStripMenuItem.Visible = true;
                alumnosToolStripMenuItem.Visible = true;
                profesoresToolStripMenuItem.Visible = true;
            } 
            else if (this.modelo.Tipo == 3)
            {
                actasToolStripMenuItem.Visible = true;
                
            } else if (this.modelo.Tipo == -1)
            {
                titulacionesToolStripMenuItem.Visible = true;

                datosInstitucionalesToolStripMenuItem.Visible = true;
                modificarInstitucionToolStripMenuItem.Visible = true;
                directivosToolStripMenuItem.Visible = true;
                departamentosToolStripMenuItem.Visible = true;
                carrerasToolStripMenuItem.Visible = true;

                bitacoraToolStripMenuItem.Visible = true;
                actasToolStripMenuItem.Visible = true;
                firmarToolStripMenuItem.Visible = true;
                alumnosToolStripMenuItem.Visible = true;
                lugaresDeTitulacionToolStripMenuItem.Visible = true;
                profesoresToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
            }
        }

        private void abrirSecundarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secundario formulario = new Secundario();
            if (!FormularioDuplicado(formulario))
            {
                formulario.MdiParent = this;
                formulario.Show();
            }

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("No es correcto mostrar formulario si no son MDI","Titulo",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Error);

            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Elegiste si");
            }
            else if (r == DialogResult.No)
            {
                MessageBox.Show("Elegiste no");
            }
            else if (r == DialogResult.Cancel)
            {
                MessageBox.Show("Elegiste cancel");
            }
        }

        private void dialogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secundario formulario = new Secundario();
            formulario.ShowDialog();
        }

        private bool FormularioDuplicado(Form frm)
        {
            bool valor = false;

            foreach (Form fr in this.MdiChildren)
            {
                if (fr.GetType() == frm.GetType())
                {
                    fr.Activate();
                    fr.WindowState = FormWindowState.Normal;
                    valor = true;
                }
            }

            return valor;
        }

        private void muestraFormulario(Form frm)
        {
            if (!FormularioDuplicado(frm))
            {
                frm.MdiParent = this;
                //frm.Show();
            }
        }

        private void firmarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Actas.actasFirmar(modelo));
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Actas.actasVisualizar(modelo));
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Alumnos.alumnosAgregar(modelo));
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Alumnos.alumnosModificar(modelo));
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.LugaresTitulacion.lugarAgregar(modelo));
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.LugaresTitulacion.lugarModificar(modelo));
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Profesores.profesoresAgregar(modelo));
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Profesores.profesoresAgregar(modelo));
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Usuarios.usuariosAgregar(modelo));
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Usuarios.usuariosDesactivar(modelo));
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Usuarios.usuariosModificar(modelo));
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Querys.cerrarApp(modelo.Usuario);
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Bitacora.bitacoraConsulta(modelo));
        }

        private void modificarInstitucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.DatosInstitucionales.institucionModificar(modelo));
        }

        private void agregarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Directivos.directivosAgregar(modelo));
        }

        private void modificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Directivos.directivosAgregar(modelo));
        }

        private void agrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Departamentos.departamentosAgregar(modelo));
        }

        private void modificarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Departamentos.departamentosModificar(modelo));
        }

        private void agregarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Carreras.carrerasAgregar(modelo));
        }

        private void modificarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Carreras.carrerasModificar(modelo));
        }

        private void agregarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Titulaciones.titulacionAgregar(modelo));
        }

        private void modificarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new views.Titulaciones.titulacionModificar(modelo));
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Querys.cerrarApp(modelo.Usuario);
        }
    }
}
