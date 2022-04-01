using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XApr08Menus.Models
{
    internal class UsuariosModelValidator
    {

        private UsuariosModel _model;

        public UsuariosModelValidator(UsuariosModel modelo)
        {
            _model = modelo;
            Validar();
        }

        public void Validar()
        {
            if (_model == null)
            {
                throw new Exception("Error de datos...");
            }
        }
    }
}
