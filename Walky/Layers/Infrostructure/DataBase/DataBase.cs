using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walky.Layers.Infrostructure.DataBase
{
    internal class DataBase
    {
        List<Data> datas;
        public void AddData(Data data)
        {
            datas.Add(data);
        }
    }
}
