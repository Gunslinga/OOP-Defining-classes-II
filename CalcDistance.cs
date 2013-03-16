using System;

public static class CalcDistance
{
    public static double CalculateDistance(Point3D point1, Point3D point2)
    {
        double x = point2.X - point1.X;
        double y = point2.Y - point1.Y;
        double z = point2.Z - point1.Z;
        return Math.Sqrt(x * x + y * y + z * z);
    }
}
