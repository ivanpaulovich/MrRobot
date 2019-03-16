namespace MrRobot.Core.Boundaries.Clean
{
    public sealed class Response
    {
        public int UniquePlacesCleaned { get; }
        public Response(int uniquePlacesCleaned)
        {
            UniquePlacesCleaned = uniquePlacesCleaned;
        }
    }
}