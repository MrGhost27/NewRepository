using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public interface IEvent : IConversation
    {
        List<String> eventChoices { get; set; }
        string EventDecisionText();
        string ChoiceOne();
        string ChoiceTwo();
        string ChoiceThree();
    }
}
