namespace MrRobot.Domain.Cleaning.Run
{
    using System.Collections.Generic;
    
    public sealed class RunUseCase : IRunUseCase
    {
        public RunOutput Execute(Position initialPosition, IList<Command> commands)
        {
            HashSet<Position> uniquePlaces = new HashSet<Position>();
            uniquePlaces.Add(initialPosition);

            Position newPosition = initialPosition;

            foreach(Command command in commands) 
                newPosition = Move(uniquePlaces, newPosition, command.Direction, command.NumSteps);

            return new RunOutput(uniquePlaces.Count);
        }

        private Position Move(HashSet<Position> uniquePlaces, Position initialPosition, Direction direction, int steps)
        {
            Position position = null;

            for(int i = 1; i <= steps; i++)
            {
                if (direction == Direction.East)
                {
                    position = new Position(initialPosition.X + i, initialPosition.Y);
                    uniquePlaces.Add(position);
                }

                if (direction == Direction.West)
                {
                    position = new Position(initialPosition.X - i, initialPosition.Y);
                    uniquePlaces.Add(position);
                }

                if (direction == Direction.South)
                {
                    position = new Position(initialPosition.X, initialPosition.Y + i);
                    uniquePlaces.Add(position);
                }

                if (direction == Direction.North)
                {
                    position = new Position(initialPosition.X, initialPosition.Y - i);
                    uniquePlaces.Add(position);
                }
            }

            return position;
        }
    }
}