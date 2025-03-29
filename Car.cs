// Car.cs (Separate file for the Car class)
public class Car
{
    public string brand;
    public int speed;

    public void ShowCar()
    {
        Console.WriteLine($"Car Brand: {brand}, Speed: {speed} km/h");
    }
}
