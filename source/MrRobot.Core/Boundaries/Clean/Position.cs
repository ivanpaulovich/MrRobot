namespace MrRobot.Core.Boundaries.Clean
{
    using System;

    public sealed class Position
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}