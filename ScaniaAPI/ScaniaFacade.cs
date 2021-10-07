using System.Collections.Generic;
using Scania.Data;

namespace Scania.API
{
    public class ScaniaFacade : IScaniaFacade
    {
        private readonly TruckRepository _truckRepository = new TruckRepository();

        public ScaniaFacade()
        {
            var sampleData = new SampleData();
            _truckRepository.Add(sampleData.GetData());
        }
        public void BatchUpdate(IEnumerable<Truck> updated, IEnumerable<Truck> deleted, IEnumerable<Truck> added)
        {
            _truckRepository.Delete(deleted);
            _truckRepository.Add(added);
            _truckRepository.Update(updated);
        }

        public List<Truck> GetTrucks()
        {
            return _truckRepository.All();
        }
    }
}