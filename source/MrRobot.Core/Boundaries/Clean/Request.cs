namespace MrRobot.Core.Boundaries.Clean
{
    using System.Collections.Generic;

    public sealed class Request : IRequest
    {
        public Position InitialPosition { get; }
        public IList<Command> Commands { get; }

        public Request(Position initialPosition, IList<Command> commands)
        {
            InitialPosition = initialPosition;
            Commands = commands;
        }
    }
}