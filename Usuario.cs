using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Inventario_y_ventas
{
    class Usuario
    {

        string codigo;
        string nombre;
        string nick;
        string contrasena;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nick { get => nick; set => nick = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }
}
