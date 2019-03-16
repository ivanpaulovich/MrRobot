namespace MrRobot.Core.Gateways.InMemory
{
    using MrRobot.Core.Entities;
    using MrRobot.Core.Gateways;
    using System;
    using System.Linq;

    public sealed class LocationGateway : ILocationGateway
    {
        private readonly InMemoryContext _context;

        public LocationGateway(InMemoryContext context)
        {
            _context = context;
        }

        public void Add(ILocation location)
        {
            _context.Locations.Add((Location)location);
        }

        public int GetUniqueLocations(Guid robotId)
        {
            var uniquePlaces = _context.Locations
                .Where(e => e.RobotId == robotId)
                .Count();
                
            return uniquePlaces;
        }
    }
}