using System;

class myTypes
{
    static void Main() {
        double radius;
        double area;
        double volume;
        double pi = 3.14159;
        
        radius = 4.2;
        area = 4*pi*(radius*radius);
        volume = (4/3)*pi*(radius*radius*radius);
        
        Console.WriteLine("Radius of sphear: " + radius);
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Volume: " + volume);
        
    }
}