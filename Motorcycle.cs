﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattenExercise
{
    public class Motorcycle : IVehicle
    {     
        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle!");
        }
    }
}
