using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Walky.Layers.Domain.Map;
using Walky.Layers.Domain.Questionnaire;

namespace Walky.Layers.Domain.User
{
    public interface IUser
    {
        IQuestionnaire PersonalQuestionnaire { get; set; }

        IMapPoint Position { get; set; }
        int Id { get;}
        IMapPoint ShareMapPosition();
    }
}