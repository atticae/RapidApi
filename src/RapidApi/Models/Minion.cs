using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApi.Models
{
    public class Minion
    {
        public string Name { get; set; }
        public int NumberOfEyes { get; set; }
        public Fruit FavoriteFruit { get; set; }
    }
    public enum Fruit
    {
        Banana,
        Bapple
    }
}
