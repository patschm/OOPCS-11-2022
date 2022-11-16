using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generieken;

public class Point<T> where T: class, new()
{
    public T X { get; set; }
    public T Y { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    public T Create()
    {
        T tmp = new T();
        return tmp ;
    }
}
