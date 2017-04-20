using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Especificaciones
{
    public class HagaLaMultiplicacion
    {
        public double[,] RealizarLaOperacionMatematica(double[,] matriz1, double[,] matriz2)
        {
            double totalMultiplicacion, totalSuma;
            double[,] matrizTotalMultiplicacion;
            var laValidacion = new Validaciones.ValidacionesDeLasMatrices();

            if (laValidacion.LaMatrizEstaVacia(matriz1))
            {
                throw new ArgumentNullException("La primera matriz no contiene ningún elemento");
            }
            else if (laValidacion.LaMatrizEstaVacia(matriz2))
            {
                throw new ArgumentNullException("La segunda matriz no contiene ningún elemento");
            }
            else if (laValidacion.columnasDePrimeraMatrizIgualAFilasDeSegundaMatriz(matriz1, matriz2))
            {
                totalSuma = 0;
                totalMultiplicacion = 0;
                matrizTotalMultiplicacion = new double[matriz1.GetLength(0), matriz2.GetLength(1)];

                //Ejecucion de la multiplicacion entre matriz 1 y matriz 2
                for (int i = 0; i < matriz2.GetLength(1); i++)
                {
                    for (int j = 0; j < matriz1.GetLength(0); j++)
                    {
                        for (int c = 0; c < matriz1.GetLength(1); c++)
                        {
                            totalMultiplicacion = matriz1[j, c] * matriz2[c, i];
                            Convert.ToInt32(totalMultiplicacion);
                            totalSuma += totalMultiplicacion;
                        }
                        matrizTotalMultiplicacion[j, i] = totalSuma;
                        totalMultiplicacion = 0;
                        totalSuma = 0;
                    }
                }
            }
            else
                throw new InvalidOperationException("La cantidad de columnas de la primera matriz debe ser igual a la cantidad de filas de la segunda matriz.");

            return matrizTotalMultiplicacion;                       
        }
    }
}