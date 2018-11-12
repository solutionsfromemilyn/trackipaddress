using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace IPTracker.Models
{
    public class TrackIpService : ITrackIpService
    {
        public GeoDataMapper FindData(string ip)
        {
            using (WebClient client = new WebClient())
            {
                var url = string.Format("http://api.ipstack.com/{0}?access_key={1}", ip, "6ae268daede218e5b5f2a1808d8cb612");

                // Download string.
                string value = client.DownloadString(url);

               var result =  JsonConvert.DeserializeObject<GeoDataMapper>(value);

                return result;
            }

        }
    }
}
