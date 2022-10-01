using RecetasSLN.datos.implementaciones;
using RecetasSLN.datos.interfaces;
using RecetasSLN.dominio;
using RecetasSLN.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.servicios.implementaciones
{
    internal class RecetaService : IServicio
    {
        private IRecetaDAO recetaDAO;

        public RecetaService()
        {
            recetaDAO=new RecetaDAO();
        }

        public bool guardarReceta(Receta receta)
        {
            return recetaDAO.confirmarReceta(receta);
        }

        public List<Ingrediente> obtenerIngredientes()
        {
            return recetaDAO.getIngredientes();
        }

        public int proximaReceta()
        {
            return recetaDAO.getEscalar();
        }
    }
}
