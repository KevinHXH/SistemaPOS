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





    }
}
