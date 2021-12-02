using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walky.Layers.Domain.Map;
using Walky.Layers.Domain.Questionnaire;

namespace Walky.Layers.Domain.User
{
    internal class User : IUser
    {
        private IQuestionnaire questionnaire;
        private int id;
        private IMapPoint position;

        public IQuestionnaire PersonalQuestionnaire { get => questionnaire; set => questionnaire = value; }
        public int Id { get => id; }
        public IMapPoint Position { get => position; set => position = value; }

        public IMapPoint ShareMapPosition()
        {
            return Position;
        }
    }
}
