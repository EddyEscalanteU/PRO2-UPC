using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion_6
{
    public class clsClientes
    {
        private int _IdCliente;

        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }

        private string _Nombres;

        public string Nombres { get => _Nombres; set => _Nombres = value; }

        private string _Apellidos;

        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }

    }
}
