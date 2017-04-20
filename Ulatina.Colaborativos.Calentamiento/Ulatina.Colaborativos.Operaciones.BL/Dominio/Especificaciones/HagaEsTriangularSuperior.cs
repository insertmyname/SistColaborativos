using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Especificaciones
{
    public class HagaEsTriangularSuperior
    {
        public bool RealizarLaOperacionMatematica(double[,] matriz1)
        {
            var laValidacion = new Validaciones.ValidacionesDeLasMatrices();

            if (laValidacion.LaMatrizEstaVacia(matriz1))
                throw new ArgumentNullException("La matriz no contiene ningún elemento");
            else if ((matriz1.GetUpperBound(0) / matriz1.GetUpperBound(1)) == 1)
            {
                for (int i = 1; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (matriz1[i, j] != 0)
                            return false;
                    }
                }
            }
            else
                throw new ArgumentException("La matriz debe de tener la misma cantidad de filas y columnas");
           
            return true;
        }
    }
}