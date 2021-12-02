using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walky.Layers.Domain.Map;

namespace Walky.Layers.Application
{
    internal class MapGenerator
    {
        IMap thisMap;
        public IMap GenerateMap()
        {
            var map = new GoogleMap();
            Console.WriteLine("Doesn't works, sorry!");
            return map;
        }
    }
}
