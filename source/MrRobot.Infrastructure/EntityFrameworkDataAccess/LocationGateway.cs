namespace MrRobot.Infrastructure.EntityFrameworkDataAccess
{
    using MrRobot.Core.Entities;
    using MrRobot.Core.Gateways;
    using System;
    using System.Linq;

    public sealed class LocationGateway : ILocationGateway
    {
        private MrRobotContext _mrRobotContext;

        public LocationGateway(MrRobotContext mrRobotContext)
        {
            _mrRobotContext = mrRobotContext;
        }

        private bool LocationExists(ILocation location)
        {
            var count = _mrRobotContext.Locations.Where(e => 
                e.RobotId == location.RobotId &&
                e.X == location.X &&
                e.Y == location.Y)
                .Count();

            return count > 0;
        }

        public void Add(ILocation location)
        {
            if (LocationExists(location))
                return;

            _mrRobotContext.Locations.Add ((Location)location);
            _mrRobotContext.SaveChanges ();
        }

        public int GetUniqueLocations(Guid robotId)
        {
            var uniquePlaces = _mrRobotContext.Locations
                .Where(e => e.RobotId == robotId)
                .Count();
                
            return uniquePlaces;
        }
    }
}