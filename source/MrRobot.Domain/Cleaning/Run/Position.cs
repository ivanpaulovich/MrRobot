namespace MrRobot.Domain.Cleaning.Run
{
    using System;

    public sealed class Position : IEquatable<Position>
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Position other)
        {
            return 
                this.X == other.X &&
                this.Y == other.Y;
        }

        public override bool Equals(object obj) {
            Position other = obj as Position;
            return Equals(this, other);
        }

        public override int GetHashCode()
        {
            unchecked 
            {
                int hash = 17;
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                return hash;
            }
        }
    }
}