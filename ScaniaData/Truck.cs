using System;
using System.ComponentModel.DataAnnotations;

namespace Scania.Data
{
    public class Truck
    {
        [Required] public string Id { get; set; }


        public int Power { get; set; }

        public int Weight { get; set; }

        [Required] public int FuelTank { get; set; }

        public int Payload { get; set; }

        [Required] public int NrTires { get; set; }

        public int Wheelbase { get; set; }

        public string Transmission { get; set; }

        [Required] public string Engine { get; set; }

        protected bool Equals(Truck other)
        {
            return Power == other.Power && Weight == other.Weight && FuelTank == other.FuelTank &&
                   Payload == other.Payload && NrTires == other.NrTires && Wheelbase == other.Wheelbase &&
                   Transmission == other.Transmission && Engine == other.Engine;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Truck) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Power, Weight, FuelTank, Payload, NrTires, Wheelbase, Transmission, Engine);
        }
    }
}