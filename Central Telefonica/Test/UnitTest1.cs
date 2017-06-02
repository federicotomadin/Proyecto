using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaSerializacion;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Local local = new Local("115476105", "1154761606", 30f, 2.65f);
            Provincial provincia = new Provincial("115476105", "1154761606", 21f, Franja.Franja_1);


             local.Equals(provincia);

            
        }
    }
}
