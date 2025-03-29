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
// example # 1
        Car myCar = new Car();
        myCar.brand = "Honda";
        myCar.speed = 100;
        myCar.ShowCar();  // Output: Car Brand: Toyota, Speed: 120 km/h
        
// example # 2
        Bike myBike = new Bike();
        myBike.brand="Honda";
        myBike.speed=90;
        myBike.model=2025;
        myBike.ShowBike();

// example # 3
        Van myVan= new Van();
        myVan.brand="Suzuki";
        myVan.model="2025";
        myVan.speed="90";
        myVan.ShowVan();

// example # 4
        Scooter myScooter= new Scooter();
        myScooter.brand="Suzuki";
        myScooter.model=2025;
        myScooter.price=90000;
        myScooter.ShowScooter();
// example # 5
        Cycle myCycle=new Cycle(); //cONSTRUCTOR
        myCycle.brand="Sohrab";
        myCycle.price=3000;
        myCycle.model=2025;
        myCycle.ShowCycle();


    }
    
}

