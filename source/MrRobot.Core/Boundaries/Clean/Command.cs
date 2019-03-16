namespace MrRobot.Core.Boundaries.Clean
{
    public sealed class Command
    {
        public int StepsCount { get; }
        public Direction Direction { get; }

        public Command(int stepsCount, Direction direction)
        {
            StepsCount = stepsCount;
            Direction = direction;
        }
    }
}