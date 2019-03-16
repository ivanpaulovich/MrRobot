using System.Collections.Generic;
using System.Collections.ObjectModel;
using MrRobot.Core.Boundaries.Clean;
using MrRobot.Core.Entities;

namespace MrRobot.Core.Gateways.InMemory
{
    public sealed class InMemoryContext
    {
        public HashSet<Location> Locations { get; set; }

        public InMemoryContext()
        {
            Locations = new HashSet<Location>();
        }
    }
}