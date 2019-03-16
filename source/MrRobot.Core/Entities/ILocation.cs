namespace MrRobot.Core.Entities
{
    using System;

    public interface ILocation
    {
        Guid RobotId { get; }
        int X { get; }
        int Y { get; }
    }
}