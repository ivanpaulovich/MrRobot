namespace MrRobot.Core.UseCases
{
    using System.Collections.Generic;
    using MrRobot.Core.Boundaries.Clean;
    using MrRobot.Core.Boundaries;
    using MrRobot.Core.Entities;
    using MrRobot.Core.Gateways;

    public sealed class Clean : IUseCase<Request>
    {
        private IResponseHandler<Response> _responseHandler;
        private ILocationGateway _locationGateway;
        private IEntitiesFactory _entitiesFactory;

        public Clean(
            IResponseHandler<Response> responseHandler,
            ILocationGateway locationGateway,
            IEntitiesFactory entitiesFactory)
        {
            _responseHandler = responseHandler;
            _locationGateway = locationGateway;
            _entitiesFactory = entitiesFactory;
        }

        public void Execute(Request request)
        {
            IRobot robot = _entitiesFactory.NewRobot();

            robot.SetInitialLocation(request.InitialPosition.X, request.InitialPosition.Y);
            _locationGateway.Add(robot.CurrentLocation);

            foreach (Command command in request.Commands)
                Walk(robot, command.Direction, command.StepsCount);

            var response = new Response(_locationGateway.GetUniqueLocations(robot.Id));
            _responseHandler.Handle(response);
        }

        private void Walk(IRobot robot, Direction direction, int stepsCount)
        {
            for (int i = 1; i <= stepsCount; i++)
            {
                if (direction == Direction.East)
                    robot.MoveEast();

                if (direction == Direction.West)
                    robot.MoveWest();

                if (direction == Direction.South)
                    robot.MoveSouth();

                if (direction == Direction.North)
                    robot.MoveNorth();

                _locationGateway.Add(robot.CurrentLocation);
            }
        }
    }
}