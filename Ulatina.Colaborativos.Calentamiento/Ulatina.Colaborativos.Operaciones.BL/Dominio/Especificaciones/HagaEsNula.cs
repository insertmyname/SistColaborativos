using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Especificaciones
{
    public class HagaEsNula
    {
        public bool RealizarLaOperacionMatematica(double[,] matriz1)
        {
            int sum = 0; //variable que sumara todos los elementos 
            var laValidacion = new Validaciones.ValidacionesDeLasMatrices();

            if (laValidacion.LaMatrizEstaVacia(matriz1))
                throw new ArgumentNullException("La matriz no contiene ningún elemento");
            else
            {
                for (int i = 0; i < matriz1.GetLength(0); i++)
                { //Tamaño de filas

                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    { //Tamaño de columnas
                        sum += Convert.ToInt32(matriz1[i, j]);
                    }
                }

                if (sum == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}