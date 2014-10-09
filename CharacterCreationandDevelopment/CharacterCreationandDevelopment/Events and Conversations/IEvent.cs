using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public interface IEvent : IConversation
    {
        List<string> eventChoices { get; set; }
        string EventDecisionText();
		List<string> ChoiceOne();
		List<string> ChoiceTwo();
		List<string> ChoiceThree();
    }
}
