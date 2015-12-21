using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace RapidApi.Controllers
{
    [Route("/api/[controller]")]
    public class ValuesController : Controller
    {
        public IEnumerable<string> Get()
        {
            return new[] {"Mein erster Wert", "Noch ein Wert"};
        }
    }
}