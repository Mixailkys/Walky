using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walky.Layers.Domain.Questionnaire
{
    internal class ExtendedQuestionnaire : IQuestionnaire
    {
        private string heading = "It's Extended Questionnaire";
        public string Heading { get => heading; }
    }
}
