namespace MrRobot.Core.Entities
{
    using System;
    using MrRobot.Core.Boundaries.Clean;

    public interface IRobot
    {
        Guid Id { get; }
        ILocation CurrentLocation { get; }
        void SetInitialLocation(int x, int y);
        void MoveEast();
        void MoveWest();
        void MoveSouth();
        void MoveNorth();
    }
}