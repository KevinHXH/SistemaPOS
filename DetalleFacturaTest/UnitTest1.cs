using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace DetalleFacturaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void calcular2X1Gelatina()
        {
            int cantidad = 2;
            int resultadoEsperado = 250;
            decimal resObtenido = DetalleFacturaLN.calcula2X1(cantidad);
            Assert.AreEqual(resultadoEsperado, resObtenido);
        }

        [TestMethod]
        public void calcularVuelto()
        {
            decimal cliente = 200000;
            decimal total = 150000;
            int resultadoEsperado = 50000;
            decimal resObtenido = DetalleFacturaLN.calcularMontoVuelto(cliente, total);
            Assert.AreEqual(resultadoEsperado, resObtenido);
        }




    }
}
