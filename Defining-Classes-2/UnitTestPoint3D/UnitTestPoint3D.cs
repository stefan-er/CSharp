namespace UnitTestPoints
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Points;

    [TestClass]
    public class UnitTestPoint3D
    {
        [TestMethod]
        public void TestMethodEmptyConstructor()
        {
            Point3D point = new Point3D();
            Assert.AreEqual(0, point.X);
            Assert.AreEqual(0, point.Y);
            Assert.AreEqual(0, point.Z);
        }

        [TestMethod]
        public void TestMethodParamConstructor_1()
        {
            Point3D point = new Point3D(3, -5, 0);
            Assert.AreEqual(3, point.X);
            Assert.AreEqual(-5, point.Y);
            Assert.AreEqual(0, point.Z);
        }

        [TestMethod]
        public void TestMethodParamConstructor_2()
        {
            Point3D point = new Point3D(-2.56f, 50.786f, -567.45123f);
            Assert.AreEqual(-2.56f, point.X);
            Assert.AreEqual(50.786f, point.Y);
            Assert.AreEqual(-567.45123f, point.Z);
        }

        [TestMethod]
        public void TestMethodToString()
        {
            Point3D point = new Point3D(3, 5, 7);
            string result = point.ToString();
            Assert.AreEqual("(3, 5, 7)", result);
        }

        [TestMethod]
        public void TestMethodStartPointO()
        {
            Assert.AreEqual(0, Point3D.O.X);
            Assert.AreEqual(0, Point3D.O.Y);
            Assert.AreEqual(0, Point3D.O.Z);
        }
    }
}
