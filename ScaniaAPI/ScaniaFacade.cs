using System.Collections.Generic;
using System.Threading.Tasks;
using Scania.Data;

namespace Scania.API
{
    public class ScaniaFacade : IScaniaFacade
    {
        private readonly TruckRepository _truckRepository = new TruckRepositorySampleData();

        public ScaniaFacade()
        {
           }

        public virtual async Task BatchUpdate(IEnumerable<Truck> updated, IEnumerable<Truck> deleted,
            IEnumerable<Truck> added)
        {
            // Just future proof so method is async
            await Task.CompletedTask;

            _truckRepository.Delete(deleted);
            _truckRepository.Add(added);
            _truckRepository.Update(updated);
        }

        public virtual async Task<List<Truck>> GetTrucks()
        {
            await Task.CompletedTask;

            return _truckRepository.All();
        }
    }
}