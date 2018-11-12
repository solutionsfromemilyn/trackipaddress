using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPTracker.Models
{
    interface ITrackIpService
    {

        GeoDataMapper FindData(string ip);

    }
}
