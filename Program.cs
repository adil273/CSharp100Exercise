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
        myCar.brand = "Honda";
        myCar.speed = 100;
        myCar.ShowCar();  // Output: Car Brand: Toyota, Speed: 120 km/h
        
        Bike myBike = new Bike();
        myBike.brand="Honda";
        myBike.speed=90;
        myBike.model=2025;
        myBike.ShowBike();

        Van myVan= new Van();
        myVan.brand="Suzuki";
        myVan.model="2025";
        myVan.speed="90";
        myVan.ShowVan();

    }
    
}

