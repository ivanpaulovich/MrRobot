namespace MrRobot.Core.Entities
{
    using System;

    public class Location : ILocation, IEquatable<Location>
    {
        public virtual Guid RobotId { get; protected set; }
        public virtual int X { get; protected set; }
        public virtual int Y { get; protected set; }

        public Location(Guid robotId, int x, int y)
        {
            RobotId = robotId;
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            Location other = obj as Location;
            return Equals(this, other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + RobotId.GetHashCode();
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                return hash;
            }
        }

        public bool Equals(Location other)
        {
            return 
                this.RobotId == other.RobotId &&
                this.X == other.X &&
                this.Y == other.Y;
        }
    }
}