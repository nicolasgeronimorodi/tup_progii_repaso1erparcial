using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.interfaces
{
    internal interface IRecetaDAO
    {
        int getEscalar();
        List<Ingrediente> getIngredientes();

        bool confirmarReceta(Receta receta);





    }
}
