using System;
using Mediator_Pattern.src.Mediator;

namespace Mediator_Pattern.src.Components
{
    public class IComponent
    {
        protected IMediator _mediator;

        public IComponent(IMediator mediator = null)
        {
            this._mediator = mediator;
        }
        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public void ReceiveMessage(string msg, Object sender)
        {
            Console.WriteLine("Você tem uma nova mensagem:\n");
            Console.WriteLine($"{msg}\n");
        }
    }
}