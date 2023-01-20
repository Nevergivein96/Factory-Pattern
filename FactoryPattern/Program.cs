using System;
namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int NumberOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the number of tires you want for the vehicle to have");

                input = int.TryParse(Console.ReadLine(), out NumberOfWheels);
            } while (input==false);

            var vehicle = VehicleFactory.GetVehicle(NumberOfWheels);
            vehicle.Drive();
                       
            
            
        }
    }
}   
