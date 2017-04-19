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
            SumaPruebaCorrecta();              
        }

        public void SumaPruebaCorrecta()
        {
            //Prueba Correcta números positivos y negativos
            // definición del escenario
            var listaDeElementosMatriz1 = new double[3, 3] { { 3, -5, 4 }, { 9, 8, -7 }, { -6, 4, 2 } };
            var listaDeElementosMatriz2 = new double[3, 3] { { -2, -1, 1 }, { 5, -7, 6 }, { 9, 3, 2 } };
            var elResultadoEsperado = new double[3, 3] { { 1, -6, 5 }, { 14, 1, -1 }, { 3, 7, 4 } };

            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Dominio.Acciones.Suma();
            var elResultadoObtenido = laAccion.HacerOperacion(listaDeElementosMatriz1, listaDeElementosMatriz2);

            // verifique el resultado obtenido
            CollectionAssert.AreEqual(elResultadoEsperado, elResultadoObtenido);                      
        }
        public void SumaPruebaIncorrecta()
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
    }
}
