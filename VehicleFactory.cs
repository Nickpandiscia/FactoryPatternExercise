using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattenExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle()
        {           
            Console.WriteLine("We have a Chevy vehicle or a new Harley in stock. Do you want 4 wheels or 2?");
            var theAnswer = int.Parse(Console.ReadLine());
                       
            switch (theAnswer)
            {
                case 4:
                    return  new Car();                   
                case 2:
                    return new Motorcycle();
                    default:
                    return null;

            }

        }
    }
}
