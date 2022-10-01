using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {
        public int RecetaNro { get; set; }  
        public string Nombre { get; set; }

        public int TipoReceta { get; set; }

        public string Chef { get; set; }

        public List<DetalleReceta> Detalles { get; set; }

        public Receta(int recetaNro, string nombre, int tipoReceta, string chef, List<DetalleReceta> detalles)
        {
            RecetaNro = recetaNro;
            Nombre = nombre;
            TipoReceta = tipoReceta;
            Chef = chef;
            Detalles = detalles;
        }

        public Receta()
        {
            RecetaNro = 0;
            Nombre=string.Empty;
            TipoReceta = 0;
            Chef = string.Empty;
            Detalles = new List<DetalleReceta>();

        }

        public void AgregarDetalle(DetalleReceta detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int i)
        {
            Detalles.RemoveAt(i);
        }

    }
}
