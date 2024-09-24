using System;

public class Car
{

    private string make;
    private string model;
    private int year;
    private float fuelLevel;

    public Car(string make, string model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.fuelLevel = 0;
    }

    public void Refuel(float amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Amount must be positive.");
            return;
        }
        fuelLevel += amount;
        Console.WriteLine($"Refueled {amount} liters. Current fuel level: {fuelLevel} liters.");
    }

    public void Drive(float distance)
    {
        float fuelNeeded = distance / 10; // I assumed  fuel efficiency of 10 km/l
        if (fuelLevel >= fuelNeeded)
        {
            fuelLevel -= fuelNeeded;
            Console.WriteLine($"Drove {distance} km. Remaining fuel: {fuelLevel} liters.");
        }
        else
        {
            Console.WriteLine("Not enough fuel to drive.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car Make: {make}, Model: {model}, Year: {year}, Fuel Level: {fuelLevel} liters.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", 2020);
        
        myCar.DisplayInfo();
        myCar.Refuel(20);
        myCar.Drive(100);
        myCar.DisplayInfo();
    }
}