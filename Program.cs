using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FactoryPattenExercise;

namespace FactoryPatternExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the car store! Are you looking for a new vehicle?");            
            var personsAnswer = Console.ReadLine();

            if(personsAnswer == "yes")
            {
                var myNewCar = VehicleFactory.GetVehicle();
                myNewCar.Drive();
            }
            else
            {
                Console.WriteLine("Sorry, that wasn't a valid answer");
            }
        }
    }
}
