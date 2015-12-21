using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using RapidApi.Models;

namespace RapidApi.Controllers
{
    [Route("api/[controller]")]
    public class MinionsController : Controller
    {
        private static readonly IList<Minion> _minions = new List<Minion> {
            new Minion { Name = "Stuart", NumberOfEyes = 1, FavoriteFruit = Fruit.Bapple },
            new Minion { Name = "Kevin", NumberOfEyes = 1, FavoriteFruit = Fruit.Banana }
        };

        [HttpGet]
        public IEnumerable<Minion> GetMinions()
        {
            return _minions;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var minion = _minions.SingleOrDefault(m => string.Equals(m.Name, id, StringComparison.CurrentCultureIgnoreCase));
            if (minion == null)
                return HttpNotFound("No Minion found with this name: " + id);
            return new ObjectResult(minion);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Minion minion)
        {
            _minions.Add(minion);
            return CreatedAtAction(nameof(Get), new { id = minion.Name }, minion);
        }
    }
}
