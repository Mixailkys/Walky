using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walky.Layers.Domain.Questionnaire
{
    internal class SimpleQuestionnaire : IQuestionnaire
    {
        private string heading = "It's Simpe Questionnaire";
        public string Heading { get => heading;}
    }
}
