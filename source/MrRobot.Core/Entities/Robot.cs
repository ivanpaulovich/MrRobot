namespace MrRobot.Core.Entities
{
    using System;
    using MrRobot.Core.Boundaries.Clean;

    public class Robot : IRobot
    {
        public virtual Guid Id { get; protected set; }
        public virtual ILocation CurrentLocation { get; protected set; }

        public Robot()
        {
            Id = Guid.NewGuid();
        }

        public void MoveEast()
        {
            CurrentLocation = new Location(Id, CurrentLocation.X + 1, CurrentLocation.Y);
        }

        public void MoveWest()
        {
            CurrentLocation = new Location(Id, CurrentLocation.X - 1, CurrentLocation.Y);
        }

        public void MoveSouth()
        {
            CurrentLocation = new Location(Id, CurrentLocation.X, CurrentLocation.Y + 1);
        }

        public void MoveNorth()
        {
            CurrentLocation = new Location(Id, CurrentLocation.X, CurrentLocation.Y - 1);
        }

        public void SetInitialLocation(int x, int y)
        {
            CurrentLocation = new Location(Id, x, y);
        }
    }
}