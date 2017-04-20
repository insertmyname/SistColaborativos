using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Especificaciones
{
    public class HagaObtenerDiagonal
    {
        public double[] RealizarLaOperacionMatematica(double[,] matriz1)
        {

            double[] matrizDiagonal;
            var laValidacion = new Validaciones.ValidacionesDeLasMatrices();

            if (laValidacion.LaMatrizEstaVacia(matriz1))
                throw new ArgumentNullException("La matriz no contiene ningún elemento");
            else if ((matriz1.GetUpperBound(0) / matriz1.GetUpperBound(1)) == 1)
            {
                matrizDiagonal = new double[matriz1.GetLength(0)];

                //Tamaño de filas
                for (int i = 0; i < matriz1.GetLength(0); i++)
                    matrizDiagonal[i] = matriz1[i, i];                
            }
            else
                throw new ArgumentException("La matriz debe de tener la misma cantidad de filas y columnas");

            return matrizDiagonal;
        }
    }
}