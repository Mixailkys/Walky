using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walky.Layers.Domain.Questionnaire;

namespace Walky.Layers.Application
{
    internal class QuestionnaireMaker
    {
        IQuestionnaire questionnaire;

        public SimpleQuestionnaire MakeQuestionnaire()
        {
            return new SimpleQuestionnaire();
        }
    }
}
