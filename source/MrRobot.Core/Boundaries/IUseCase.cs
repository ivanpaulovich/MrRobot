namespace MrRobot.Core.Boundaries
{
    public interface IUseCase<in TRequest>
        where TRequest : IRequest
        {
            void Execute(TRequest request);
        }
}