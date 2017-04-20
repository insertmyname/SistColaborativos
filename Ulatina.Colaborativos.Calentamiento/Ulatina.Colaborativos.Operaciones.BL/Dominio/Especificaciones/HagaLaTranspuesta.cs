using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Especificaciones
{
    public class HagaLaTranspuesta
    {
        public double[,] RealizarLaOperacionMatematica(double[,] matriz1)
        {
            double[,] matrizTranspuesta;
            var laValidacion = new Validaciones.ValidacionesDeLasMatrices();

            if (laValidacion.LaMatrizEstaVacia(matriz1))
                throw new ArgumentNullException("La matriz no tiene ningún elemento");
            else
            {
                matrizTranspuesta = new double[matriz1.GetLength(1), matriz1.GetLength(0)];
                for(int i = 0; i < matriz1.GetLength(0); i++)
                    for(int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        matrizTranspuesta[j, i] = matriz1[i, j];
                    }
            }           
            return matrizTranspuesta;
        }
    }
}