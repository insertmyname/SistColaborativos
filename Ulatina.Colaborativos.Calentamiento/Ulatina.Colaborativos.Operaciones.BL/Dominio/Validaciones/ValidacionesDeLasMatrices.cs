using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Validaciones
{
    public class ValidacionesDeLasMatrices
    {
        public bool LaMatrizContieneAlMenosUnElemento(double[,] matriz1)
        {
            bool elResultado;
            elResultado = matriz1.Length > 0;
            return elResultado;
        }

        public bool LaMatrizEstaVacia(double[,] matriz1)
        {
            bool elResultado;
            elResultado = !LaMatrizContieneAlMenosUnElemento(matriz1);
            return elResultado;
        }
    }
}