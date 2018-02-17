using System.Collections.Generic;
using System.Linq;

using element885.web.Common;
using element885.web.Models;

using Newtonsoft.Json;

using Microsoft.AspNetCore.Mvc;

namespace element885.web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var json = System.IO.File.ReadAllText(Constants.PLAYLIST_FILENAME);

            return string.IsNullOrEmpty(json) ? View(new List<SongListingItem>()) : View(JsonConvert.DeserializeObject<List<SongListingItem>>(json).OrderBy(a => a.Name).ToList());
        }
    }
}