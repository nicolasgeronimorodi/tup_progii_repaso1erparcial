using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.servicios.interfaces
{
    internal interface IServicio
    {
        List<Ingrediente> obtenerIngredientes();

        int proximaReceta();

        bool guardarReceta(Receta receta);

    }
}
