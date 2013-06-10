namespace Points
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath (Path path, StreamWriter file)
        {
            string points = string.Join("|", path.Points);
            file.WriteLine(points);
        }

        public static List<Path> LoadPaths(StreamReader file)
        {
            List<string> pathsFromFile = new List<string>();
            using (file)
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    pathsFromFile.Add(line);
                }
            }

            List<Path> paths = new List<Path>();
            foreach (var path in pathsFromFile)
            {
                string[] points = path.Split('|');
                Point3D[] points3D = new Point3D[points.Length];
                for (int i = 0; i < points.Length; i++)
                {
                    points3D[i] = new Point3D(points[i]);
                }
                paths.Add(new Path(points3D));
            }

            return paths;
        }
    }
}
