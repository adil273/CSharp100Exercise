// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello, World!");
//     }
// }
// Program.cs (Where we create objects)
class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.brand = "Toyota";
        myCar.speed = 120;
        myCar.ShowInfo();  // Output: Car Brand: Toyota, Speed: 120 km/h
    }
}

