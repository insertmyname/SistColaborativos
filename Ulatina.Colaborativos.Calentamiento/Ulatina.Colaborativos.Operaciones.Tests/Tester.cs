using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ulatina.Colaborativos.Operaciones.Tests
{
    [TestClass]
    public class Tester
    {
        [TestMethod]
        public void TestMethod1()
        {
            // definición del escenario
            var laListaDeElementos = new double[3,2] { {2,3}, {10, 4.6 }, { -2.1, 5 } };
            var elResultadoEsperado = 12.5;

            // invoque al método de prueba
            var laAccion = new Ulatina.Colaborativos.Operaciones.BL.Acciones.Suma();
            var elResultadoObtenido = laAccion.HacerOperacion(laListaDeElementos);

            // verifique el resultado obtenido
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
