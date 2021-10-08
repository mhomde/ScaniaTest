using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Scania.API;
using Scania.Data;

namespace Scania.Services
{
    /// <summary>
    ///     Wrap Facade  so we can add authorization
    /// </summary>
    public class ScaniaFacadeAuthorized : ScaniaFacade
    {
        [Authorize(Roles = "Admin")]
        public override async Task BatchUpdate(IEnumerable<Truck> updated, IEnumerable<Truck> deleted,
            IEnumerable<Truck> added)
        {
            await base.BatchUpdate(updated, deleted, added);
        }
    }
}