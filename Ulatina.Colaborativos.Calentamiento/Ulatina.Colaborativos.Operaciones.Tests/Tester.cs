using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Ulatina.Colaborativos.Operaciones.Tests
{
    [TestClass]
    public class Tester
    {
        [TestMethod]
        public void Automatizado()
        {
            esNulaPruebaIncorrecta();              
        }

        public void sumaPruebaCorrecta()
        {
            //Prueba Correcta números positivos, negativos y decimales
            // definición del escenario
            var listaDeElementosMatriz1 = new double[3, 3] { { 3, -5, 4.7 }, { 9.8, 8, -7 }, { -6, 4.9, 2 } };
            var listaDeElementosMatriz2 = new double[3, 3] { { -2, -1.3, 1 }, { 5.2, -7, 6 }, { 9, 7.5, -4 } };
            var elResultadoEsperado = new double[3, 3] { { 1, -6.3, 5.7 }, { 15.0, 1, -1 }, { 3, 12.4, -2 } };

            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.Suma();
            var elResultadoObtenido = laAccion.HacerOperacion(listaDeElementosMatriz1, listaDeElementosMatriz2);

            // verifique el resultado obtenido
            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);                      
        }
        public void sumaPruebaIncorrecta()
        {
            //Prueba Incorrecta matrices de diferentes longitudes 
            // definición del escenario
            var matriz1ConElementos = new double[3, 3] { { 3, -5, 4 }, { 9, 8, -7 }, { -6, 4, 2 } };
            var matriz2ConElementos = new double[1, 2] { { -2, -1 } };
            var elResultadoRequerido = new double[3, 3] { { 1, -6, 5 }, { 14, 1, -1 }, { 3, 7, 4 } };

            // invoque al método de prueba
            var accionSuma = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.Suma();
            var elResultadoCalculado = accionSuma.HacerOperacion(matriz1ConElementos, matriz2ConElementos);

            // verifique el resultado obtenido
            CollectionAssert.AreEqual(elResultadoRequerido, elResultadoCalculado);
        }

        public void multiplicacionPruebaCorrecta()
        {
            //Prueba Correcta números positivos, negativos y decimales
            // definición del escenario
            var listaDeElementosMatriz1 = new double[2, 3] { { 5, -2.5, 3 }, { -5, 5, 4 } };
            var listaDeElementosMatriz2 = new double[3, 1] { { 5 }, { -2 }, { 4.0 } };
            var elResultadoEsperado = new double[2, 1] { { 42 }, { -19 } };

            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.Multiplicacion();
            var elResultadoObtenido = laAccion.HacerOperacion(listaDeElementosMatriz1, listaDeElementosMatriz2);

            // verifique el resultado obtenido
            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void multiplicacionPruebaIncorrecta()
        {
            //Prueba Incorrecta # de columnas de matriz 1 no igual a # de filas de matriz 2
            // definición del escenario
            var listaDeElementosMatriz1 = new double[2, 3] { { 5, -2.5, 3 }, { -5, 5, 4 } };
            var listaDeElementosMatriz2 = new double[1, 1] { { 5 } };
            var elResultadoEsperado = new double[2, 1] { { 42 }, { -19 } };

            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.Multiplicacion();
            var elResultadoObtenido = laAccion.HacerOperacion(listaDeElementosMatriz1, listaDeElementosMatriz2);

            // verifique el resultado obtenido
            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void transpuestaPruebaCorrecta()
        {
            //Prueba Correcta números positivos, negativos y decimales
            // definición del escenario
            var listaDeElementosMatriz1 = new double[7, 3] { { 0, 0.5, 4 }, { -1, 0, 4.7 }, { 0, 1.8, 0 }, 
                { 0, -3, 2 }, { 0.2, 2, -3 }, { 0, 3.9, -4 }, { 3, 3, -1 } };            
            var elResultadoEsperado = new double[3, 7] { { 0, -1, 0, 0, 0.2, 0, 3 }, { 0.5, 0, 1.8, -3, 2, 3.9, 3 },
                { 4, 4.7, 0, 2, -3, -4, -1} };

            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.Transpuesta();
            var elResultadoObtenido = laAccion.HacerOperacion(listaDeElementosMatriz1);

            // verifique el resultado obtenido
            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void transpuestaPruebaIncorrecta()
        {
            //Prueba Incorrecta la matriz que se agrega como argumento no tiene ningún elemento
            // definición del escenario
            var listaDeElementosMatriz1 = new double[0, 0] { };
            var elResultadoEsperado = new double[3, 7] { { 0, -1, 0, 0, 0.2, 0, 3 }, { 0.5, 0, 1.8, -3, 2, 3.9, 3 },
                { 4, 4.7, 0, 2, -3, -4, -1} };

            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.Transpuesta();
            var elResultadoObtenido = laAccion.HacerOperacion(listaDeElementosMatriz1);

            // verifique el resultado obtenido            
            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        public void simétricaPruebaCorrecta()
        {
            //Prueba Correcta números positivos, negativos
            // definición del escenario
            var listaDeElementosMatriz1 = new double[3, 3] { { 0, 1, 2 }, { -1, 0, 3 }, { -2, -3, 0} };
            
            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.Simetrica();
            var elResultadoObtenido = laAccion.HacerOperacion(listaDeElementosMatriz1);

            // verifique el resultado obtenido
            Assert.IsTrue(elResultadoObtenido);
        }

        public void simétricaPruebaIncorrecta()
        {
            //Prueba Inorrecta matriz no es cuadrada
            // definición del escenario
            var listaDeElementosMatriz1 = new double[3, 2] { { 2, 1 }, { 1, 0 }, { 3, -2 } };            

            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.Simetrica();
            var elResultadoObtenido = laAccion.HacerOperacion(listaDeElementosMatriz1);

            // verifique el resultado obtenido
            Assert.IsTrue(elResultadoObtenido);
        }

        public void esNulaPruebaCorrecta()
        {
            //Prueba Correcta valor resultante es nulo o cero.
            // definición del escenario
            var listaDeElementosMatriz1 = new double[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.EsNula();
            var elResultadoObtenido = laAccion.HacerOperacion(listaDeElementosMatriz1);

            // verifique el resultado obtenido
            Assert.IsTrue(elResultadoObtenido);
        }

        public void esNulaPruebaIncorrecta()
        {
            //Prueba Incorrecta valor resultante no es cero o nulo
            // definición del escenario
            var listaDeElementosMatriz1 = new double[3, 3] { { 0, 7, 0 }, { -8, 0, 0 }, { 0, 7, 3 } };

            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.EsNula();
            var elResultadoObtenido = laAccion.HacerOperacion(listaDeElementosMatriz1);

            // verifique el resultado obtenido
            Assert.IsTrue(elResultadoObtenido);

        }

        public void esEscalarPruebaCorrecta()
        {
           
        }

        public void esEscalarPruebaIncorrecta()
        {

        }

        public void esTriangularSuperiorPruebaCorrecta()
        {

        }

        public void esTriangularSuperiorPruebaIncorrecta()
        {

        }

        public void obtenerDiagonalPruebaCorrecta()
        {

        }

        public void obtenerDiagonalPruebaIncorrecta()
        {

        }
    }
}
