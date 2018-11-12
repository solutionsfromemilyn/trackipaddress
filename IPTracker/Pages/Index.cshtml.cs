using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IPTracker.Models;

namespace IPTracker.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public GeoData GeoData { get; set; }

        public IActionResult OnGet()
        {
            if (GeoData == null)
            {
                GeoData = new GeoData {

                    Result = new GeoDataMapper
                    {
                        location = new GeoDataMapper.Location()
                   }

            };
                
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                TrackIpService service = new TrackIpService();
               var result  =  service.FindData(GeoData.IPAddress);

                GeoData.Result = result;
            }

            return Page();
        }

    }
}
