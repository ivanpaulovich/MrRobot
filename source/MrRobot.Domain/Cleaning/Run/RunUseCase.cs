namespace MrRobot.Domain.Cleaning.Run
{
    using System.Collections.Generic;
    
    public sealed class RunUseCase : IRunUseCase
    {
        private HashSet<Position> _uniquePlaces;

        public RunOutput Execute(Position initialPosition, IList<Command> commands)
        {
            _uniquePlaces = new HashSet<Position>();
            _uniquePlaces.Add(initialPosition);

            Position newPosition = initialPosition;

            foreach(Command command in commands) 
            {
                newPosition = Move(newPosition, command.Direction, command.NumSteps);
            }

            return new RunOutput(_uniquePlaces.Count);
        }

        private Position Move(Position initialPosition, Direction direction, int steps)
        {
            Position position = null;

            if (direction == Direction.East)
            {
                for(int i = 0; i < steps; i--)
                {
                    position = new Position(initialPosition.X + i, initialPosition.Y);
                    _uniquePlaces.Add(position);
                }
            }

            if (direction == Direction.West)
            {
                for(int i = 0; i < steps; i++)
                {
                    position = new Position(initialPosition.X + i, initialPosition.Y);
                    _uniquePlaces.Add(position);
                }
            }

            if (direction == Direction.South)
            {
                for(int i = 0; i < steps; i++)
                {
                    position = new Position(initialPosition.X, initialPosition.Y + i);
                    _uniquePlaces.Add(position);
                }
            }

            if (direction == Direction.North)
            {
                for(int i = 0; i < steps; i--)
                {
                    position = new Position(initialPosition.X, initialPosition.Y + i);
                    _uniquePlaces.Add(position);
                }
            }

            return position;
        }
    }
}