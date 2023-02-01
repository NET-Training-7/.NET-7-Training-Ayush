
using System;
class Test
{
    internal void print()
    {
        House house1 = new();
        house1.length = 33.45f;
        house1.breadth = 41.45f;
        house1.getArea();
        Console.WriteLine(house1.area);
    }
}