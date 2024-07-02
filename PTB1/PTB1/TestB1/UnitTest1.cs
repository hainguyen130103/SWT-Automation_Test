using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PTB1;

namespace PTB1_Test
{
    [TestClass]
    public class UnitTest1
    {
        private Giai c;
       
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
           c = new Giai(2,4);
        }
        
        [TestMethod] //TC1: a =2, b = 4, kq= -2
        public void Testphuongtrinhconghiem_08_TruongQuangDat()
        {
            double expected, actual;        
            expected = -2;
            actual = c.Solve();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Testphuongtrinhvosonghiem_08_TruongQuangDat()
        {
            Giai c = new Giai(0.0, 0.0);


            Assert.ThrowsException<ArgumentException>(() => c.Solve());

        }
        [TestMethod]
        public void Testphuongtrinhvonghiem_08_TruongQuangDat()
        {
            Giai c = new Giai(0,3);
            

            Assert.ThrowsException<ArgumentException>(() => c.Solve());

        }      
       
    }
}
