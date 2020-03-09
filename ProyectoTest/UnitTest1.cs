using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace ProductoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void calcularDescuentoProducto()
        {
            int des = 5;
            int total = 300;
            int resEsperado = 285;

            decimal reslObtenido =  ProductoLN.calcularDescuento(des, total);
            Assert.AreEqual(resEsperado, reslObtenido);
        }




    }
}
