using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XApr08Menus.Utilerias;

namespace XApr08Menus.views
{
    public partial class CombosyListas : Form
    {
        public CombosyListas()
        {
            InitializeComponent();
            ArrayList param = new ArrayList();
            Querys.llenarCombo(cmbDeptos, btnDeptos, 3, param, false);
            Querys.LlenarLstBox(lstDepto,btnDepto,3, param, false);
        }

        private void btnDeptos_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();
            param.Add(cmbDeptos.SelectedValue.ToString());
            Querys.llenarCombo(cmbCarreras, btnCarrera, 4 ,param, false);
            Querys.LimpiarCombo(cmbProfesores, btnProfesores);
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();
            param.Add(cmbCarreras.SelectedValue.ToString());
            Querys.llenarCombo(cmbProfesores, btnProfesores, 5, param, false);
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {

        }

        private void btnDepto_Click(object sender, EventArgs e)
        {
            if (lstDepto.SelectedItems.Count > 0)
            {
                Querys.LimpiarListBox(lstProfes, btnProfesL);
                ArrayList param =  new ArrayList();
                for (int x = 0; x < lstDepto.SelectedItems.Count; x++)
                {
                    param.Add(((KeyValuePair<string,string>)lstDepto.SelectedItems[x]).Key);
                }
                Querys.LlenarLstBox(lstCarrera, btnCarreraL, 4, param, false);
            } else
            {
                Querys.LimpiarListBox(lstCarrera, btnCarreraL);
                Querys.LimpiarListBox(lstProfes, btnProfesL);
                MessageBox.Show("No seleccionaste nada");
            }
        }

        private void btnCarreraL_Click(object sender, EventArgs e)
        {
            if (lstCarrera.SelectedItems.Count > 0)
            {
                ArrayList param = new ArrayList();
                for (int x = 0; x  < lstCarrera.SelectedItems.Count; x ++)
                {
                    param.Add(((KeyValuePair<string,string>)lstCarrera.SelectedItems[x]).Key);
                }
                Querys.LlenarLstBox(lstProfes, btnProfesL,5,param, false);
            } else
            {
                Querys.LimpiarListBox(lstProfes, btnProfesL);
                MessageBox.Show("No seleccionaste nada");
            }
        }
    }
}
