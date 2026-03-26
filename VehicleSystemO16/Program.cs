using System;
					
public class Program
{
	public static void Main()
	{
		Truck truck = new Truck();
        truck.StartEngine(); // Output: Truck engine started
        truck.LoadCargo(); // Output: Truck cargo loaded

        Car Car = new Car();
        Car.StartEngine();
        car.PlayRadio();

        Motorcycle motorcycle = new Motorcycle();
        motorcycle.StartEngine(); 
        motorcycle.PopWheelie();
	}
}