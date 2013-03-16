using System;
using System.Collections.Generic;

public class Path
{
    private List<Point3D> _points;

    public Path(List<Point3D> points)
    {
        this._points = points;
    }

    public List<Point3D> Points
    {
        get { return this._points; }
    }

    public override string ToString()
    {
        return string.Format("{0}", this.Points);
    }
}

