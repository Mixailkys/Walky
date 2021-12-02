using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walky.Layers.Application;

namespace Walky.Layers.UserInterface.GUI
{
    internal class GUI
    {
        private readonly MapGenerator mapGenerator = new MapGenerator();

        public void ShowTheMap()
        {
            mapGenerator.GenerateMap();
        }
    }
}
