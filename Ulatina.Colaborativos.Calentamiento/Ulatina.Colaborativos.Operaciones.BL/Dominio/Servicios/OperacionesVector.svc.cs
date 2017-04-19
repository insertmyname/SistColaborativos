using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ulatina.Colaborativos.Operaciones.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OperacionesVector" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OperacionesVector.svc or OperacionesVector.svc.cs at the Solution Explorer and start debugging.
    public class OperacionesVector : IOperacionesVector
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public double[,] Suma(double[,] matriz1, double[,] matriz2)
        {
            // declare la variable para invocar a la acción
            Dominio.Acciones.Suma laAccion = new Dominio.Acciones.Suma();
            // invoque al método correspondiente
            double[,] elResultado = laAccion.HacerOperacion(matriz1, matriz2);

            // retorne el resultado
            return elResultado;
        }

        public double[,] Multiplicacion(double[,] matriz1, double[,] matriz2)
        {
            // declare la variable para invocar a la acción
            Dominio.Acciones.Multiplicacion laAccion = new Dominio.Acciones.Multiplicacion();
            // invoque al método correspondiente
            double[,] elResultado = laAccion.HacerOperacion(matriz1, matriz2);

            // retorne el resultado
            return elResultado;
        }

        public double[,] Transpuesta(double[,] matriz1)
        {
            // declare la variable para invocar a la acción
            Dominio.Acciones.Transpuesta laAccion = new Dominio.Acciones.Transpuesta();
            // invoque al método correspondiente
            double[,] elResultado = laAccion.HacerOperacion(matriz1);

            // retorne el resultado
            return elResultado;
        }

        public bool Simetrica(double[,] matriz1)
        {
            // declare la variable para invocar a la acción
            Dominio.Acciones.Simetrica laAccion = new Dominio.Acciones.Simetrica();
            // invoque al método correspondiente
            bool elResultado = laAccion.HacerOperacion(matriz1);

            // retorne el resultado
            return elResultado;
        }

        public bool EsNula(double[,] matriz1)
        {
            // declare la variable para invocar a la acción
            Dominio.Acciones.EsNula laAccion = new Dominio.Acciones.EsNula();
            // invoque al método correspondiente
            bool elResultado = laAccion.HacerOperacion(matriz1);

            // retorne el resultado
            return elResultado;
        }

        public bool EsEscalar(double[,] matriz1)
        {
            // declare la variable para invocar a la acción
            Dominio.Acciones.EsEscalar laAccion = new Dominio.Acciones.EsEscalar();
            // invoque al método correspondiente
            bool elResultado = laAccion.HacerOperacion(matriz1);

            // retorne el resultado
            return elResultado;
        }

        public bool EsTriangularSuperior(double[,] matriz1)
        {
            // declare la variable para invocar a la acción
            Dominio.Acciones.EsTriangularSuperior laAccion = new Dominio.Acciones.EsTriangularSuperior();
            // invoque al método correspondiente
            bool elResultado = laAccion.HacerOperacion(matriz1);

            // retorne el resultado
            return elResultado;
        }

        public IEnumerable<double> ObtenerDiagonal(double[,] matriz1)
        {
            // declare la variable para invocar a la acción
            Dominio.Acciones.ObtenerDiagonal laAccion = new Dominio.Acciones.ObtenerDiagonal();
            // invoque al método correspondiente
            IEnumerable<double> elResultado = laAccion.HacerOperacion(matriz1);

            // retorne el resultado
            return elResultado;
        }
       
    }
}
