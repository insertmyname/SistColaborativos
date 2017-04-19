using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones
{
    public class Suma
    {
        /// <summary>
        /// realiza la operación que indica el nombre de la clase
        /// </summary>
        /// <param name="matriz1">Elementos de la matriz que se desean sumar</param>
        /// <returns>Total obtenido de la suma entre los elementos de dos matrices</returns>
        /// /// <param name="matriz2">Elementos de la matriz que se desean sumar</param>
        /// <returns>Total obtenido de la suma entre los elementos de dos matrices</returns>
        public double[,] HacerOperacion(double[,] matriz1, double[,] matriz2)
        {
            double[,] resultado;

            Especificaciones.HagaLaSuma laEspecificacion =
                    new Especificaciones.HagaLaSuma();
            resultado = laEspecificacion.RealizarLaOperacionMatematica(matriz1,matriz2);

            return resultado;
        }

    }
}