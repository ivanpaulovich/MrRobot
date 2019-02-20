namespace MrRobot.Domain.Cleaning.Run
{
    using System.Collections.Generic;
    
    public sealed class RunUseCase : IRunUseCase
    {
        private readonly int _minCommands;
        private readonly int _maxCommands;
        private readonly int _minX;
        private readonly int _maxX;
        private readonly int _minY;
        private readonly int _maxY;

        public RunUseCase(int minCommands, int maxCommands, int minX, int maxX, int minY, int maxY)
        {
            _minCommands = minCommands;
            _maxCommands = maxCommands;
            _minX = minX;
            _maxX = maxX;
            _minY = minY;
            _maxY = maxY;
        }

        public RunOutput Execute(Position initialPosition, IList<Command> commands)
        {
            throw new System.NotImplementedException();
        }
    }
}