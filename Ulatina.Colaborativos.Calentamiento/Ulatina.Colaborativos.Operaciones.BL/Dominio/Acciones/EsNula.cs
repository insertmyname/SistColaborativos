using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones
{
    public class EsNula
    {
        /// <summary>
        /// realiza la operación que indica el nombre de la clase
        /// </summary>
        /// <param name="matriz1">Lista de los elementos que se desean verificar sus valores</param>
        /// <returns>Los valores de la matriz deben ser cero</returns> 
         public bool HacerOperacion(double[,] matriz1)
        {
            bool resultado;

            Especificaciones.HagaEsNula laEspecificacion =
                    new Especificaciones.HagaEsNula();
            resultado = laEspecificacion.RealizarLaOperacionMatematica(matriz1);
            return resultado;
        }
}
}