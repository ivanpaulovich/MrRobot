namespace MrRobot.Domain.Cleaning.Run
{
    public sealed class Command
    {
        public Direction Direction { get; }
        public int NumSteps { get; }

        public Command(Direction direction, int numSteps)
        {
            Direction = direction;
            NumSteps = numSteps;
        }
    }
}