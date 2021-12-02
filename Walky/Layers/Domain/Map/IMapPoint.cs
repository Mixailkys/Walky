using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Walky.Layers.Domain.Map
{
    public interface IMapPoint
    {
        Point Coordinate { get; set; }
    }
}