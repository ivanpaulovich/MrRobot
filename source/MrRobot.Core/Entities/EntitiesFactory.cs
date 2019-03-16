namespace MrRobot.Core.Entities
{
    using System;

    public class EntitiesFactory : IEntitiesFactory
    {
        public ILocation NewLocation(Guid id, int x, int y)
        {
            var location = new Location(id, x, y);
            return location;
        }

        public IRobot NewRobot()
        {
            var robot = new Robot();
            return robot;
        }
    }
}