using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point Add(Point x, Point y)
    {
        return new Point { Y = y.Y + x.Y, X = x.X + y.X };
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
