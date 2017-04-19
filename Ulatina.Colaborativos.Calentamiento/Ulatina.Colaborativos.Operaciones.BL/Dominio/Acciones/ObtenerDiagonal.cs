using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones
{
    public class ObtenerDiagonal
    {
        /// <summary>
        /// realiza la operación que indica el nombre de la clase
        /// </summary>
        /// <param name="matriz1">Lista de los elementos que se desean obtener sus valores</param>
        /// <returns>Los valores de la diagonal principal en una variable</returns> 
        public IEnumerable<double> HacerOperacion(double[,] matriz1)
        {
            IEnumerable<double> resultado;
            
            Especificaciones.HagaObtenerDiagonal laEspecificacion =
                    new Especificaciones.HagaObtenerDiagonal();
            resultado = laEspecificacion.RealizarLaOperacionMatematica(matriz1);
            return resultado;
        }
    }
}