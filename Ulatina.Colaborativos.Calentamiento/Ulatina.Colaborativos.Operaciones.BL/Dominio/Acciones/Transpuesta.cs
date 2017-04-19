using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones
{
    public class Transpuesta
    {
        /// <summary>
        /// realiza la operación que indica el nombre de la clase
        /// </summary>
        /// <param name="matriz1">Lista de los elementos que se desean cambiar su orden</param>
        /// <returns>Los valores de las columnas se convierten en los valores de lsa filas</returns>        
        public double[,] HacerOperacion(double[,] matriz1)
        {
            double[,] resultado;

            Especificaciones.HagaLaTranspuesta laEspecificacion =
                    new Especificaciones.HagaLaTranspuesta();
            resultado = laEspecificacion.RealizarLaOperacionMatematica(matriz1);
            return resultado;
        }
    }
}