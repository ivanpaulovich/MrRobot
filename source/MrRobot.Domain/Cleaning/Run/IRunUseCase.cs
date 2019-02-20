namespace MrRobot.Domain.Cleaning.Run
{
    using System.Collections.Generic;
    
    public interface IRunUseCase
    {
        RunOutput Execute(Position initialPosition, IList<Command> commands);
    }
}