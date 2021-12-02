using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walky.Layers.Domain.User;
using Walky.Layers.Infrostructure.DataBase;

namespace Walky.Layers.Application
{
    internal class UserMaker
    {
        static DataBase dataBase = new DataBase();
        UserLoger loger;
        IUser User;

        User MakeUser()
        {
            return new User();
        }

        void LogToDataBase()
        {
            dataBase.AddData(loger.LogIn());
        }
    }
}
