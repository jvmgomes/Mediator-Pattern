
namespace Mediator_Pattern.src.Mediator
{
    public interface IMediator
    {
        void Notify(string msg, Object sender);
    }
}