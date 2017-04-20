using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Especificaciones
{
    public class HagaLaSuma
    {
        public double[,] RealizarLaOperacionMatematica(double[,] matriz1, double[,] matriz2)
        {
           
            double[,] matrizTotalSuma;
            var laValidacion = new Validaciones.ValidacionesDeLasMatrices();

            if (laValidacion.LaMatrizEstaVacia(matriz1))
                throw new ArgumentNullException("La primera matriz no contiene ningún elemento");
            else if(laValidacion.LaMatrizEstaVacia(matriz2))
                throw new ArgumentNullException("La segunda matriz no contiene ningún elemento");
            else if (laValidacion.dosMatricesConIgualCantidadFilasYColumnas(matriz1, matriz2))
            {
                matrizTotalSuma = new double[matriz1.GetLength(0), matriz1.GetLength(1)];

                //Ejecucion de la suma entre matriz 1 y matriz1
                for (int i = 0; i < matrizTotalSuma.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizTotalSuma.GetLength(1); j++)
                    {
                        matrizTotalSuma[i, j] = matriz1[i, j] + matriz2[i, j];                       
                    }
                }
            }
            else
                throw new ArgumentOutOfRangeException("Ambas matrices deben tener la misma cantidad de filas y columnas.");
                 
            return matrizTotalSuma;
        }
    }
}