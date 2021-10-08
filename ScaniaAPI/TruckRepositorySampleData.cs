using Scania.Data;

namespace Scania.API
{
    public class TruckRepositorySampleData : TruckRepository
    {
        public TruckRepositorySampleData()
        {
            var sampleData = new SampleData();
            Add(sampleData.GetData());
        }
    }
}