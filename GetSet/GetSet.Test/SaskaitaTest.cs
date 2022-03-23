using GetSet.Business2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GetSet.Test
{
    [TestClass]
    public class SaskaitaTest
    {
        [TestMethod]
        public void CreateAccount_FieldsSetCorrectly()
        {
            Saskaita saskaita = new Saskaita("Petras", "Jonas", 50);

            Assert.AreEqual("Jonas", saskaita.Siuntejas);
            Assert.AreEqual("Petras", saskaita.Gavejas);
            Assert.AreEqual(50, saskaita.MoketiViso);
            Assert.AreEqual($"NR_{DateTime.Now.ToString("yyyy_MM_dd")}_01", saskaita.SaskaitosNumeris);
        }
    }
}