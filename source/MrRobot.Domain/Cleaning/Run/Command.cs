namespace MrRobot.Domain.Cleaning.Run
{
    public sealed class Command
    {
        public int NumSteps { get; }
        public Direction Direction { get; }

        public Command(int numSteps, Direction direction)
        {
            NumSteps = numSteps;
            Direction = direction;
        }
    }
}