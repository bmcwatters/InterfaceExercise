using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        string Year { get; set; }
        string Model { get; set; }
        string Make { get; set; }
        int Wheels { get; set; }

        void Drive();






    }






}
