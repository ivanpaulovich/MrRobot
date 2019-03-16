namespace MrRobot.Core.Entities
{
    using System;

    public interface IEntitiesFactory
    {
        IRobot NewRobot();
        ILocation NewLocation(Guid id, int x, int y);
    }
}