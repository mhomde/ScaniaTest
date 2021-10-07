using System;
using System.ComponentModel.DataAnnotations;

namespace Scania.Data
{
    public class Truck
    {
        public Truck()
        {
            
        }

        [Required] 
        public string Id { get; set; } 


        public int Power { get; set; }

        public int Weight { get; set; }

        [Required]
        public int FuelTank { get; set; }

        public int Payload { get; set; }

        [Required]
        public int NrTires { get; set; }

        public int Wheelbase { get; set; }

        public string Transmission { get; set; }

        [Required]
        public string Engine { get; set; }
    }
}