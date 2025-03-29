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
        Scooter myScooter=new Scooter();
        myScooter.brand="Kawasaki";
        myScooter.price=120000;
        myScooter.model=2020;
        myScooter.ShowScooter();

    }
    
}

