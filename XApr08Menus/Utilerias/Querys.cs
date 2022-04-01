using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using XApr08Menus.Models;

namespace XApr08Menus.Utilerias
{
    internal class Querys
    {

        /*
        [0] - ID
        [1] - Actas validar
        [2] - Actas visualizar
        [3] - Alumnos agregar
        [4] - Alumnos modificar
        [5] - Lugares Titulacion agregar
        [6] - Lugares Titulacion modificar
        [7] - Profesores agregar
        [8] - Profesores modificar
        [9] - Usuarios agregar
        [10] - Usuarios modificar
        [11] - Usuarios desactivar
        [12] - Bitacora consulta
        [13] - Datos institucion modificar
        [14] - Directivos agregar
        [15] - Directivos modificar
        [16] - Departamentos agregar
        [17] - Departamentos modificar
        [18] - Carreras agregar
        [19] - Carreras modificar
        [20] - Titulaciones agregar
        [21] - Titulaciones agregar
         */

        private static string sCn = "Data Source=SALVADOR\\SQLEXPRESS;Initial Catalog=Actas19091317;" + "Persist Security Info=True;User ID=sa;Password=123";

        private static readonly int[,] permisos = new int[5, 22] {
            /*Posiciones seran ID*/
            {-1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            { 0,0,0,0,0,1,1,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0},
            { 1,1,1,0,0,1,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1},
            { 2,0,1,1,1,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
            { 3,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        };

        private static readonly string[] querys = new string[10] {
            "EXEC sp_Login '{0}', '{1}';",
            "EXEC sp_Logout '{0}';",
            "EXEC sp_InsertarUsuario '{0}', '{1}', '{2}', '{3}', '{4}';",
            "SELECT ID, Nombre FROM Departamentos",
            "SELECT Clave, Nombre FROM Carreras",
            "SELECT noTarjeta, Nombre FROM Profesores",
            "SELECT Usuario, Nombre FROM Usuarios",
            "EXEC sp_BorrarUsuario '{0}', '{1}'",
            "SELECT Estado FROM usuarios WHERE Usuario = '{0}' AND Borrado = 0;",
            "EXEC sp_CambiarEstadoUsuario {0},'{1}','{2}'"
        };

        private static readonly string[] filtros = new string[10] {
            "","","","",
            "IDDepto = '{0}'",
            "ClaveCarrera = '{0}'",
            "Tipo > 0",
            "",
            "",
            ""
        };

        private static readonly string noBorrado = "Borrado = 0";

        public static void BorrarUsuario(int nQ, string usr, string usra)
        {
            string[] param = new string[2] { usr, usra};
            ejecutarNonQuery(crearQuery(param,nQ));
        }

        public static void cambiarEstadoUsuario(bool estado, string usr, string usra)
        {
            string est = "0";
            if (estado)
            {
                est = "1";
            }
            ejecutarNonQuery(crearQuery(new string[3] { est, usr, usra }, 9));
        }

        private static void ejecutarNonQuery(string q)
        {
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand cmd = new SqlCommand(q, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static bool estadoUsuario(string usr)
        {
            return queryEstadoUsuario(usr);
        }

        private static bool queryEstadoUsuario(string usr)
        {
            bool estado = false;
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand cmd = new SqlCommand(crearQuery(new string[1] { usr }, 8), con);
            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            while ( r.Read() )
            {
                estado = r.GetBoolean(0);
            }
            con.Close();
            return estado;
        }
        private static Dictionary<string, string> LeerRegistros(int nQ, ArrayList param, bool incluirBorrado)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            string q = querys[nQ] + " WHERE ";

            /*if (nQ < 3 || nQ > 5)
            {
                throw new Exception("Error general...");
            }*/

            if (nQ == 6)
            {
                q = q + filtros[nQ] + " AND ";
            }

            if (!incluirBorrado)
            {
                q = q + noBorrado;
            }

            if (param.Count > 0)
            {
                q = q + "WHERE ";
                for (int x = 0; x < param.Count; x++)
                {
                    q = q + filtros[nQ] + " ";
                    q = q.Replace("{0}", param[x].ToString());

                    if (x < param.Count - 1)
                    {
                        q = q + "OR ";
                    }
                }
            }
            MessageBox.Show(q);

            SqlConnection conn = new SqlConnection(sCn);
            SqlCommand cm = new SqlCommand(q, conn);
            conn.Open();
            SqlDataReader r = cm.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    if (r[0].GetType().ToString() == "System.Int32")
                    {
                        datos.Add(r.GetInt32(0).ToString(), r.GetString(1));
                    } else
                    {
                        datos.Add(r.GetString(0), r.GetString(1));
                    }
                }
            } else
            {
                datos.Add("-1", "No hay datos");
            }
            conn.Close();
            return datos;
        }

        public static void LlenarLstBox(ListBox lst, Button btn, int nQ, ArrayList param, bool incluirBorrados)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();

            LimpiarListBox(lst, btn);
            datos = LeerRegistros(nQ, param, incluirBorrados);
            lst.DataSource = new BindingSource(datos, null);
            lst.DisplayMember = "Value";
            lst.ValueMember = "Key";
            lst.SelectedIndex = 0;
            if (((KeyValuePair<string, string>)lst.Items[0]).Value.ToString() == "-1")
            {
                EstadoList(lst, btn, false);
            } else
            {
                EstadoList(lst, btn, true);
            }
        }

        public static void LimpiarListBox(ListBox lst, Button btn)
        {
            lst.DataSource = null;
            lst.Items.Clear();
            EstadoList(lst, btn, false);
        }

        public static void EstadoList(ListBox lst, Button btn, bool estado)
        {
            lst.Enabled = estado;
            btn.Enabled = estado;
        }

        public static void llenarCombo(ComboBox cmb, Button btn, int nQ, ArrayList param, bool incluirBorrados)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            

            LimpiarCombo(cmb, btn);

            datos = LeerRegistros(nQ, param, incluirBorrados);
            cmb.DataSource = new BindingSource(datos, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "Key";
            cmb.SelectedIndex = 0;
            if (cmb.SelectedValue.ToString() == "-1")
            {
                EstadoCombo(cmb, btn, false);
            } else
            {
                EstadoCombo(cmb, btn, true);
            }
        }

        public static void LimpiarCombo(ComboBox cmb, Button btn) {
            cmb.DataSource = null;
            cmb.Items.Clear();
            EstadoCombo(cmb, btn, false);
        }

        public static void EstadoCombo(ComboBox cmb, Button btn, bool estado)
        {
            cmb.Enabled = estado;
            btn.Enabled = estado;
        }

        public static UsuariosModel buscarUsuarios(string usuario, string clave)
        {
            UsuariosModel aux = null;

            string[] param = { usuario, clave };

            SqlConnection con = new SqlConnection(sCn);
            SqlCommand cmd = new SqlCommand(crearQuery(param, 0), con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                aux = new UsuariosModel(reader.GetString(1), reader.GetString(0), reader.GetInt32(2));
            }
            con.Close();
            return aux;
        }

        public static void cerrarApp(string usuario)
        {
            string [] param = { usuario };
            ejecutarNonQuery(crearQuery(param, 1));
            System.Windows.Forms.Application.Exit();
        }

        public static void agregarUsuario(string usr, string nombre, string clv, string tipo, string usra)
        {
            string[] param = { usr, nombre, clv, tipo, usra};
            ejecutarNonQuery(crearQuery(param, 2));
        }

        private static string crearQuery(string[] parametros, int numero)
        {
            string q = querys[numero];

            for (int i = 0; i < parametros.Length; i++)
            {
                q = q.Replace("{"+i+"}",parametros[i]);
            }

            return q;
        }

        public static void llenarTipo(System.Windows.Forms.ComboBox cmb)
        {
            cmb.DataSource = null;
            Dictionary<string, string> tipos = new Dictionary<string, string>()
            {
                { "0","Administrador"},
                { "1","Coordinador" },
                { "2","Secretaria" },
                { "3","Alumno"}
            };

            cmb.DataSource = new BindingSource(tipos, null);
            cmb.ValueMember = "Key";
            cmb.DisplayMember = "Value";
            cmb.SelectedIndex = 0;
        }

        public static bool tienePermiso(int Tipo, int Formulario)
        {
            bool tiene = false;
            int posX = 3;

            switch (Tipo)
            {
                case -1:
                    posX = 0;
                    break;
                case 0:
                    posX = 1;
                    break;
                case 1:
                    posX = 2;
                    break;
                case 2:
                    posX = 3;
                    break;
                    posX = 4;
                case 3:
                    break;
            }

            if (permisos[posX,Formulario] == 1)
            {
                tiene = true;
            }

            /*
            for (int x = 0; x < 5; x++)
            {
                if (permisos[x,0] == Tipo)
                {
                    for (int y = 0; y < 22; y++)
                    {
                        if (permisos[x,y] == Formulario)
                        {
                            tiene = true;
                        }
                    }
                }
            }*/

            return tiene;
        }

    }
}
