namespace Points
{
    using System;

    public struct Point3D
    {
        private static Point3D o = new Point3D(0, 0, 0);
        private float x;
        private float y;
        private float z;

        public Point3D(string coordinates)
            : this()
        {
            string[] coords = coordinates.Split(new char[] { ',', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            this.X = float.Parse(coords[0]);
            this.Y = float.Parse(coords[1]);
            this.Z = float.Parse(coords[2]);
        }

        public Point3D(float x, float y, float z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D O
        {
            get { return o; }
        }

        public float X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public float Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public float Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}
