namespace MrRobot.Core.Boundaries
{
    public interface IResponseHandler<in TResponse>
    {
        void Handle(TResponse response);
    }
}