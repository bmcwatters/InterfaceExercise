using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany  
    {

        
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public  bool HasTrunk { get; set; }
        public int Wheels { get; set; }
        public string Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateEstablished { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }






    }
}
