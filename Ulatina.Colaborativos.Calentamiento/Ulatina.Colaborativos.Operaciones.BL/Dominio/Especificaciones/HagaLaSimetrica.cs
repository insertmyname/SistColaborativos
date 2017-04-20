using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Especificaciones
{
    public class HagaLaSimetrica
    {
        public bool RealizarLaOperacionMatematica(double[,] matriz1)
        {
            bool resultado = false;
            double[,] matrizTranspuesta;
            var laValidacion = new Validaciones.ValidacionesDeLasMatrices();

            if (laValidacion.LaMatrizEstaVacia(matriz1))
                throw new ArgumentNullException("La matriz no contiene ningún elemento");
            else if ((matriz1.GetUpperBound(0) / matriz1.GetUpperBound(1)) == 1)
            {
                Especificaciones.HagaLaTranspuesta laEspecificacion =
                        new Especificaciones.HagaLaTranspuesta();
                matrizTranspuesta = laEspecificacion.RealizarLaOperacionMatematica(matriz1);

                for (int i = 0; i < matriz1.GetLength(0); i++)
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        if (matrizTranspuesta[j, i] == matriz1[i, j])
                            resultado = true;
                        else
                        {
                            resultado = false;
                            return resultado;
                        }

                    }
            }
            else
                throw new ArgumentException("La matriz debe de tener la misma cantidad de filas y columnas");
            
            return resultado;
        }
    }
}