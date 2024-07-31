using _2001216219_TranVanTinh_Buoi3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVuong()
        {
            double a=3,b=4,c=5;
            string s = Test.ktraTamGiac(a, b, c);
            string t = "Tam giac vuong";
            Assert.AreEqual(s, t);
        }
        [TestMethod]
        public void TestCan()
        {
            double a = 3, b = 3, c = 5;
            string s = Test.ktraTamGiac(a, b, c);
            string t = "Tam giac can";
            Assert.AreEqual(s, t);
        }
        [TestMethod]
        public void TestThuong()
        {
            double a = 3, b = 7, c = 5;
            string s = Test.ktraTamGiac(a, b, c);
            string t = "Tam giac thuong";
            Assert.AreEqual(s, t);
        }
        [TestMethod]
        public void TestDeu()
        {
            double a = 3, b = 3, c = 3;
            string s = Test.ktraTamGiac(a, b, c);
            string t = "Tam giac deu";
            Assert.AreEqual(s, t);
        }
    }
}
