namespace MrRobot.Infrastructure.EntityFrameworkDataAccess
{
    using MrRobot.Core.Entities;
    using MrRobot.Core.Gateways;
    using System.Linq;

    public sealed class RobotGateway : IRobotGateway
    {
        private MrRobotContext _mrRobotContext;

        public RobotGateway(MrRobotContext mrRobotContext)
        {
            _mrRobotContext = mrRobotContext;
        }

        public void Add(IRobot robot)
        {
            _mrRobotContext.Robots.Add ((Robot)robot);
            _mrRobotContext.SaveChanges ();
        }
    }
}