using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ulatina.Colaborativos.Operaciones.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOperacionesVector" in both code and config file together.
    [ServiceContract]
    public interface IOperacionesVector
    {
        /// <summary>
        /// realiza la operación de suma de una lista de elementos
        /// </summary>
        /// <param name="matriz1">Elementos de la matriz que se desean sumar</param>
        /// <returns>Total obtenido de la suma entre los elementos de dos matrices</returns>
        /// <param name="matriz2">Elementos de la matriz que se desean sumar</param>
        /// <returns>Total obtenido de la suma entre los elementos de dos matrices</returns>
        [OperationContract]
        double[,] Suma(double[,] matriz1, double[,] matriz2);

        /// <summary>
        /// realiza la operación de suma de una lista de elementos
        /// </summary>
        /// <param name="matriz1">Elementos de la matriz que se desean sumar</param>
        /// <returns>Total obtenido de la suma entre los elementos de dos matrices</returns>
        /// <param name="matriz2">Elementos de la matriz que se desean sumar</param>
        /// <returns>Total obtenido de la suma entre los elementos de dos matrices</returns>
        [OperationContract]
        double[,] Multiplicacion(double[,] matriz1, double[,] matriz2);

        /// <summary>
        /// realiza la operación de suma de una lista de elementos
        /// </summary>
        /// <param name="matriz1">Lista de los elementos que se desean cambiar su orden</param>
        /// <returns>Los valores de las columnas se convierten en los valores de las filas</returns>        
        [OperationContract]
        double[,] Transpuesta(double[,] matriz1);

        /// <summary>
        /// realiza la operación de suma de una lista de elementos
        /// </summary>
        /// <param name="matriz1">Lista de los elementos que se desean verificar sus valores</param>
        /// <returns>Los valores de la matriz original y el de la transpuesta son iguales</returns>         
        [OperationContract]
        bool Simetrica(double[,] matriz1);

        /// <summary>
        /// realiza la operación de suma de una lista de elementos
        /// </summary>
        /// <param name="matriz1">Lista de los elementos que se desean verificar sus valores</param>
        /// <returns>Los valores de la matriz deben ser cero</returns>          
        [OperationContract]
        bool EsNula(double[,] matriz1);

        /// <summary>
        /// realiza la operación de suma de una lista de elementos
        /// </summary>
        /// <param name="matriz1">Lista de los elementos que se desean verificar sus valores</param>
        /// <returns>Los valores de la diagonal principal son iguales y los demás son cero</returns>          
        [OperationContract]
        bool EsEscalar(double[,] matriz1);

        /// <summary>
        /// realiza la operación de suma de una lista de elementos
        /// </summary>
        /// <param name="matriz1">Lista de los elementos que se desean verificar sus valores</param>
        /// <returns>Los valores por arriba de la diagonal principal son distintos de cero y por debajo de 
        /// la diagonal son cero</returns>          
        [OperationContract]
        bool EsTriangularSuperior(double[,] matriz1);

        /// <summary>
        /// realiza la operación de suma de una lista de elementos
        /// </summary>
        /// <param name="matriz1">Lista de los elementos que se desean obtener sus valores</param>
        /// <returns>Los valores de la diagonal principal en una variable</returns>          
        [OperationContract]
        double[] ObtenerDiagonal(double[,] matriz1);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);       
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
