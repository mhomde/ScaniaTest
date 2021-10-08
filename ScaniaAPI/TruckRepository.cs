using System.Collections.Generic;
using System.Linq;
using Scania.Data;

namespace Scania.API
{
    public class TruckRepository
    {
        private readonly Dictionary<string, Truck> _trucks = new Dictionary<string, Truck>();

        public Truck this[string id]
        {
            get
            {
                Truck result = null;
                if (!string.IsNullOrEmpty(id)) _trucks.TryGetValue(id, out result);

                return result;
            }
        }


        public bool Contains(string id)
        {
            var result = false;

            if (!string.IsNullOrEmpty(id)) result = _trucks.ContainsKey(id);

            return result;
        }

        public void Add(Truck truck)
        {
            if (truck != null) _trucks.Add(truck.Id, truck);
        }

        public void Update(IEnumerable<Truck> trucks)
        {
            foreach (var truck in trucks) Update(truck);
        }

        public void Add(IEnumerable<Truck> trucks)
        {
            foreach (var truck in trucks) Add(truck);
        }

        public void Delete(IEnumerable<Truck> trucks)
        {
            foreach (var truck in trucks) Delete(truck);
        }

        public List<Truck> All()
        {
            var result = _trucks.Values.ToList();
            return result;
        }

        public void Update(Truck truck)
        {
            if (truck != null) _trucks[truck.Id] = truck;
        }

        public void Delete(Truck truck)
        {
            if (truck != null) _trucks.Remove(truck.Id);
        }
    }
}