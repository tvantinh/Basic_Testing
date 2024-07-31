using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestbai3
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class CanChi_Test
        {
            [TestMethod]
            public void TestCase1()
            {
                String result = bai3.AmLich.GetCanChi(2019);
                String expected = "Kỷ Hợi";
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestCase2()
            {
                String result = bai3.AmLich.GetCanChi(-1);
                String expected = "Không hợp lệ";
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestCase3()
            {
                String result = bai3.AmLich.GetCanChi(2021);
                String expected = "Tân Sửu";
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestCase4()
            {
                String result = bai3.AmLich.GetCanChi(2003);
                String expected = "Quý Mùi";
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestCase5()
            {
                String result = bai3.AmLich.GetCanChi(2024);
                String expected = "Giáp Thìn";
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestCase6()
            {
                String result = bai3.AmLich.GetCanChi(2025);
                String expected = "Ất Tị";
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestCase7()
            {
                String result = bai3.AmLich.GetCanChi(2026);
                String expected = "Bính Ngọ";
                Assert.AreEqual(expected, result);
            }
        }
    }
}
