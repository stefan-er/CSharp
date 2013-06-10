namespace Points
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class ConsoleTests
    {
        static void Main()
        {
            Point3D point1 = new Point3D(0, 5, 8);
            Point3D point2 = new Point3D(1, 2, 4);
            Point3D point3 = new Point3D(-3, 15, 60);
            Point3D[] points = { point1, point2, point3 };

            Path path = new Path(points);

            Point3D point4 = new Point3D(-10, 12, 80);
            Point3D point5 = new Point3D(11, 12, 5);
            Point3D point6 = new Point3D(-33, 155, 26);
            Point3D[] points1 = { point4, point5, point6 };

            Path path1 = new Path(points1);
            Console.WriteLine(path.Distance);

            foreach (var point in path.Points)
            {
                Console.WriteLine(point);
            }

            string filePath = @"..\..\..\TxtFiles\4thTask.txt";
            StreamWriter fileWrite = new StreamWriter(filePath, false, Encoding.GetEncoding(1251));
            using (fileWrite)
            {
                PathStorage.SavePath(path, fileWrite);
                PathStorage.SavePath(path1, fileWrite);
            }

            StreamReader fileRead = new StreamReader(filePath, Encoding.GetEncoding(1251));
            List<Path> readedPaths = PathStorage.LoadPaths(fileRead);
            foreach (var readedPath in readedPaths)
            {
                for (var i = 0; i < readedPath.Points.Length; i++)
                {
                    Console.Write(readedPath.Points[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
