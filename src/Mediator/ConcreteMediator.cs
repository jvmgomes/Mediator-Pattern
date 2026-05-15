using System;
using Mediator_Pattern.src.Components;

namespace Mediator_Pattern.src.Mediator
{
    public class ConcreteMediator : IMediator
    {
        private Dictionary<string, IComponent> _participants = new();

        public void Register(IComponent component, string id)
        {
            _participants[id] = component;
            component.SetMediator(this);
        }
     
        public void Notify(string message, object sender)
        {
            foreach (var (id, participant) in _participants)
            {
                if (participant != sender)
                    participant.ReceiveMessage(message, sender);
            }
        }
    }
}