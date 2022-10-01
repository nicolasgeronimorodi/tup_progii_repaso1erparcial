using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    internal class Parametro
    {
       

        public string Nombre { get; set; }
        public Object Valor { get; set; }

        public Parametro(string nombre, Object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }


    }
}
