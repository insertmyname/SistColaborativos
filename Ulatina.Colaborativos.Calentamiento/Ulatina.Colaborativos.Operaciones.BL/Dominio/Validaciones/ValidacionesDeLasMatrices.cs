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

        public bool dosMatricesConIgualCantidadFilasYColumnas(double[,] matriz1, double[,] matriz2)
        {
            bool elResultado;

            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) ==
                matriz2.GetLength(1))
            {
                elResultado = true;
            }
            else
                elResultado = false;
           
            return elResultado;
        }
    }
}