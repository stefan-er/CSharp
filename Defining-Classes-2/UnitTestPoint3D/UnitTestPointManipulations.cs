using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Points;

namespace UnitTestPoint3D
{
    [TestClass]
    public class UnitTestPointManipulations
    {
        [TestMethod]
        public void TestMethodTwoPoints_1()
        {
            Point3D point1 = new Point3D(0, 5, 8);
            Point3D point2 = new Point3D(1, 2, 4);
            float result = PointManipulations.PointsDistance(point1, point2);
            Assert.AreEqual(5.09902f, result);
        }

        [TestMethod]
        public void TestMethodTwoPoints_2()
        {
            Point3D point1 = new Point3D(0, 5, 8);
            Point3D point2 = new Point3D(-1, -2, -4);
            float result = PointManipulations.PointsDistance(point1, point2);
            Assert.AreEqual(13.92839f, result);
        }
    }
}
