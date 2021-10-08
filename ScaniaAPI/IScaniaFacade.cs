using System.Collections.Generic;
using System.Threading.Tasks;
using Scania.Data;

namespace Scania.API
{
    public interface IScaniaFacade
    {
        Task BatchUpdate(IEnumerable<Truck> updated, IEnumerable<Truck> deleted, IEnumerable<Truck> added);
        Task<List<Truck>> GetTrucks();
    }
}