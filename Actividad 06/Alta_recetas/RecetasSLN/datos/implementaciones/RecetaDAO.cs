using RecetasSLN.datos.interfaces;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.implementaciones
{
    internal class RecetaDAO : IRecetaDAO
    {
        public bool confirmarReceta(Receta receta)
        {
            return HelperDAO.obtenerInstancia().confirmarTransaccionReceta(receta);
        }

        public int getEscalar()
        {
            return HelperDAO.obtenerInstancia().consultarEscalar("SP_PROXIMO_ID", "@next");
        }

        public List<Ingrediente> getIngredientes()
        {
            List<Ingrediente> ingredientes=new List<Ingrediente>();
            DataTable tabla=HelperDAO.obtenerInstancia().consultarDB("SP_CONSULTAR_INGREDIENTES");

            foreach (DataRow r in tabla.Rows)
            {
                int ingredienteId = Convert.ToInt32(r[0]);
                string nombre=Convert.ToString(r[1]);
                string unidad=Convert.ToString(r[2]);
                Ingrediente ingrediente = new Ingrediente(ingredienteId, nombre, unidad);
                ingredientes.Add(ingrediente);
            }



            return ingredientes;
        }
    }
}
