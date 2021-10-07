using System.Collections.Generic;
using Scania.Data;

namespace Scania.API
{
    public interface IScaniaFacade
    {
        void BatchUpdate(IEnumerable<Truck> updated, IEnumerable<Truck> deleted, IEnumerable<Truck> added);
        List<Truck> GetTrucks();
    }
}