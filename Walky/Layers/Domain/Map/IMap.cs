using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Walky.Layers.Domain.Map
{
    public interface IMap
    {
        IMapApi MapApi { get;}
        IMapSource Source { get;}
        List<IMapPoint> MapPoints { get;}

        void Update();
        void Build();
    }
}