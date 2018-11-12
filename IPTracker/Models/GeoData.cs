using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IPTracker.Models
{
    public class GeoData
    {

        public GeoDataMapper Result { get; set; }


        [Required, StringLength(100)]
        public string IPAddress { get; set; }

    }
}
