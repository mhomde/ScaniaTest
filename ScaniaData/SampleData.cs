using System;
using System.Collections.Generic;
using System.Text;

namespace Scania.Data
{
    public class SampleData
    {
        private readonly List<Truck> _trucks = new List<Truck>();
        private int IdCounter = 0;
        public SampleData()
        {
            Add(500, 49000,500, 39270,10,3778,"Semi Automatic", "Scania DC 16 V8, Turbo");
            Add(360, 49000, 1000, 32715, 10, 3550, "Semi Automatic", "Scania DC 13, Turbo");
            Add(310, 49000, 6000, 32715, 6, 3950, "Automatic", "Scania 5-Cylinder 09 Litre");
        }

        protected void Add(int power, int weight, int fuelTank, int payload, int nrTires, int wheelbase, string transmission, string engine)
        {
            var truck = new Truck()
            {
                Engine = engine,
                Power = power,
                Weight = weight,
                FuelTank = fuelTank,
                Payload = payload,
                NrTires = nrTires,
                Wheelbase = wheelbase,
                Transmission = transmission,

            };

            truck.Id = Guid.NewGuid().ToString();

            _trucks.Add(truck);
        }
        public List<Truck> GetData()
        {
            return _trucks;
        }

    }
}
