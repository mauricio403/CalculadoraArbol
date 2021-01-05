using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasArbol2
{
    [TestClass]
    public class TestArbol
    {
        [TestMethod]
        public void CalcularArbolOperaciones() 
        {
            var expersionMatematica = "5+6-2-1";
            //5+6+(-2)+(-1) tiene que expresarse asi

            var esperado = 8;

            var calculadoraArbol = new CalculadoraArbol();

            var resultado = calculadoraArbol.Calcular(expersionMatematica);

            Assert.AreEqual(esperado, resultado);
        }
    }
}
