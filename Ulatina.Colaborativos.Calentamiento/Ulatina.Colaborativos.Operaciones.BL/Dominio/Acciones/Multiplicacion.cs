using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones
{
    public class Multiplicacion
    {
        /// <summary>
        /// realiza la operación que indica el nombre de la clase
        /// </summary>
        /// <param name="matriz1">Elementos de la matriz que se desean multiplicar</param>
        /// <returns>Total obtenido de la multiplicacion entre los elementos de dos matrices</returns>
        /// /// <param name="matriz2">Elementos de la matriz que se desean multiplicar</param>
        /// <returns>Total obtenido de la multiplicacion entre los elementos de dos matrices</returns>
        public double[,] HacerOperacion(double[,] matriz1, double[,] matriz2)
        {
            double[,] resultado;

            Especificaciones.HagaLaMultiplicacion laEspecificacion =
                    new Especificaciones.HagaLaMultiplicacion();
            resultado = laEspecificacion.RealizarLaOperacionMatematica(matriz1, matriz2);
            return resultado;
        }
    }
}