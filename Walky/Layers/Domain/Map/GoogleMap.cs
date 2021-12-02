using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walky.Layers.Domain.Map
{
    internal class GoogleMap : IMap
    {
        private IMapApi mapApi;
        private IMapSource mapSource;
        private List<IMapPoint> mapPoints; 

        public IMapApi MapApi { get => mapApi;}

        public IMapSource Source { get => mapSource;}

        public List<IMapPoint> MapPoints { get => mapPoints;}

        public void Build()
        {
        }

        public void Update()
        {
        }
    }
}
