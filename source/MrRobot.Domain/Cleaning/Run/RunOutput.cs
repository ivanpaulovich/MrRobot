namespace MrRobot.Domain.Cleaning.Run
{
    public sealed class RunOutput
    {
        public int UniquePlacesCleaned { get; }
        public RunOutput(int uniquePlacesCleaned)
        {
            UniquePlacesCleaned = uniquePlacesCleaned;
        }
    }
}