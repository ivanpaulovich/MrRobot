namespace MrRobot.Core.Gateways
{
    using System;
    using MrRobot.Core.Entities;

    public interface ILocationGateway
    {
        void Add(ILocation location);
        int GetUniqueLocations(Guid robotId);
    }
}