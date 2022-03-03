using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStructs.Structs
{
    public readonly struct Vehicle
    {
        public double MaxSpeed { get; init; }

        public string Brand { get; init; }

        /// <summary>
        /// Allows creating an empty constructor and then define the default values
        /// </summary>
        /// If not constructor is defined for the Struct,
        /// it is implicitly initialized an empty constructor
        public Vehicle() 
        {
            this.MaxSpeed = double.NaN;
            this.Brand = string.Empty;
        }

        /// <summary>
        /// Regular Constructor that we had
        /// </summary>
        /// <param name="maxSpeed"></param>
        /// <param name="brand"></param>
        public Vehicle(double maxSpeed, string brand)
        {
            this.MaxSpeed = maxSpeed;
            this.Brand = brand;
        }

        public override string ToString() => $"{this.Brand} - {this.MaxSpeed}";
    }
}   
