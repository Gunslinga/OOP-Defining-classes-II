using System;

public struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    private static readonly Point3D startPoint = new Point3D() { X = 0, Y = 0, Z = 0 };

    public static Point3D StartPoint
    {
        get { return Point3D.startPoint; }
    } 

    public override string ToString()
    {
        return string.Format("{0}, {1}, {2}",X, Y, Z);
    }
}

