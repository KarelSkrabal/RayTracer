namespace RayTracerLib
{
    public struct Point
    {
        double x;
        public double X { get => x; }
        double y;
        public double Y { get => y; }
        double z;
        public double Z { get => z; }

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
