namespace MrRobot.UnitTests
{
    using System.Collections.Generic;
    using MrRobot.Core.Boundaries.Clean;
    using MrRobot.Core.Entities;
    using MrRobot.Core.Gateways.InMemory;
    using Xunit;

    public sealed class RunCleaningUseCaseTests
    {
        [Fact]
        public void RunCleaningUseCase_ReturnsCleanedSpaces_When2Commands()
        {
            Position initialPosition = new Position(10, 22);
            List<Command> commands = new List<Command>()
            {
                new Command(2, Direction.East),
                new Command(1, Direction.North)
            };

            int expectedUniquePlacesCleaned = 4;

            Request request = new Request(initialPosition, commands);
            var responseHandler = new ResponseHandler();
            var entitiesFactory = new EntitiesFactory();
            var context = new InMemoryContext();
            var locationGateway = new LocationGateway(context);
            var sut = new Core.UseCases.Clean(responseHandler, locationGateway, entitiesFactory);
            sut.Execute(request);

            Assert.Equal(expectedUniquePlacesCleaned, responseHandler.CleanedItems[0].UniquePlacesCleaned);
        }

        [Fact]
        public void RunCleaningUseCase_ReturnsCleanedSpaces_When4Commands()
        {
            Position initialPosition = new Position(-10, 0);
            List<Command> commands = new List<Command>()
            {
                new Command(10, Direction.East),
                new Command(10, Direction.North),
                new Command(10, Direction.West),
                new Command(10, Direction.South),
            };

            int expectedUniquePlacesCleaned = 40;

            Request request = new Request(initialPosition, commands);
            var responseHandler = new ResponseHandler();
            var entitiesFactory = new EntitiesFactory();
            var context = new InMemoryContext();
            var locationGateway = new LocationGateway(context);
            var sut = new Core.UseCases.Clean(responseHandler, locationGateway, entitiesFactory);
            sut.Execute(request);

            Assert.Equal(expectedUniquePlacesCleaned, responseHandler.CleanedItems[0].UniquePlacesCleaned);
        }

        [Fact]
        public void RunCleaningUseCase_ReturnsCleanedSpaces_WhenGoingForwardThenBack()
        {
            Position initialPosition = new Position(-100, -100);
            List<Command> commands = new List<Command>()
            {
                new Command(10, Direction.East),
                new Command(10, Direction.West),
                new Command(10, Direction.East),
                new Command(10, Direction.West),
                new Command(10, Direction.East),
                new Command(10, Direction.West),
                new Command(10, Direction.East),
                new Command(10, Direction.West)
            };

            int expectedUniquePlacesCleaned = 11;

            Request request = new Request(initialPosition, commands);
            var responseHandler = new ResponseHandler();
            var entitiesFactory = new EntitiesFactory();
            var context = new InMemoryContext();
            var locationGateway = new LocationGateway(context);
            var sut = new Core.UseCases.Clean(responseHandler, locationGateway, entitiesFactory);
            sut.Execute(request);

            Assert.Equal(expectedUniquePlacesCleaned, responseHandler.CleanedItems[0].UniquePlacesCleaned);
        }

        [Fact]
        public void RunCleaningUseCase_ReturnsCleanedSpaces_WhenWalkingEdges()
        {
            Position initialPosition = new Position(-100_000, -100_000);
            List<Command> commands = new List<Command>()
            {
                new Command(200_000, Direction.East),
                new Command(200_000, Direction.South),
                new Command(200_000, Direction.West),
                new Command(200_000, Direction.North),
            };

            int expectedUniquePlacesCleaned = 800_000;

            Request request = new Request(initialPosition, commands);
            var responseHandler = new ResponseHandler();
            var entitiesFactory = new EntitiesFactory();
            var context = new InMemoryContext();
            var locationGateway = new LocationGateway(context);
            var sut = new Core.UseCases.Clean(responseHandler, locationGateway, entitiesFactory);
            sut.Execute(request);

            Assert.Equal(expectedUniquePlacesCleaned, responseHandler.CleanedItems[0].UniquePlacesCleaned);
        }
    }
}