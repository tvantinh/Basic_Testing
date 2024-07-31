using Bai2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_bai2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBac6()
        {
            TinhTienDien tinhTienDien = new TinhTienDien();
            double t = tinhTienDien.caculator(500);
            double r = 1201700;
            Assert.AreEqual(r, t);
        }
        [TestMethod]
        public void TestBac1()
        {
            TinhTienDien tinhTienDien = new TinhTienDien();
            double t = tinhTienDien.caculator(50);
            double r = 83900;
            Assert.AreEqual(r, t);
        }
        [TestMethod]
        public void TestBac2()
        {
            TinhTienDien tinhTienDien = new TinhTienDien();
            double t = tinhTienDien.caculator(100);
            double r = 170600;
            Assert.AreEqual(r, t);
        }
        [TestMethod]
        public void TestBac3()
        {
            TinhTienDien tinhTienDien = new TinhTienDien();
            double t = tinhTienDien.caculator(200);
            double r = 372000;
            Assert.AreEqual(r, t);
        }
        [TestMethod]
        public void TestBac4()
        {
            TinhTienDien tinhTienDien = new TinhTienDien();
            double t = tinhTienDien.caculator(300);
            double r = 625600;
            Assert.AreEqual(r, t);
        }
        [TestMethod]
        public void TestBac5()
        {
            TinhTienDien tinhTienDien = new TinhTienDien();
            double t = tinhTienDien.caculator(400);
            double r = 909000;
            Assert.AreEqual(r, t);
        }
    }
}
