using Mediator_Pattern.src.Mediator;
using Mediator_Pattern.src.Components;

namespace Mediator_Pattern
{
    public class Program
    {
        static void Main()
        {
            var sala = new ConcreteMediator();

            var alice = new ChatUser("Alice");
            var bob   = new ChatUser("Bob");
            var carol = new ChatUser("Carol");

            sala.Register(alice, "Alice");
            sala.Register(bob,   "Bob");
            sala.Register(carol, "Carol");

            alice.SendMessage("Olá a todos!");
            bob.SendMessage("Oi Alice, tudo bem?");
        }
    }   
}