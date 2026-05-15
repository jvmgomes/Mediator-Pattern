using System;
using Mediator_Pattern.src.Mediator;

namespace Mediator_Pattern.src.Components
{
    public class ChatUser : IComponent
    {
        public string _name { get; }
        public ChatUser(string name, IMediator mediator = null) : base(mediator)
        {
            this._name = name;
        }
        public void SendMessage(string message)
        {
            _mediator?.Notify(message, this);
        }

    }
}