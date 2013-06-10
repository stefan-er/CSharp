namespace Points
{
    using System;

    public class Path
    {
        private float distance;
        public Point3D[] Points{get; set;}

        public Path(Point3D[] points)
        {
            this.Points = points;
        }

        public float Distance
        {
            get 
            {
                for (int i = 0; i < this.Points.Length - 1; i++)
                {
                    this.distance += PointManipulations.PointsDistance(this.Points[i], this.Points[i + 1]);
                }

                return this.distance;
            }
        }
    }
}
