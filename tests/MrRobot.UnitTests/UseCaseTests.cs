namespace MrRobot.UnitTests {
    using Xunit;
    using MrRobot.Domain.Cleaning.Run;
    using System.Collections.Generic;

    public sealed class RunCleaningUseCaseTests {
        [Fact]
        public void RunCleaningUseCase_ReturnsCleanedSpaces_WhenSingleMovement() {
            Position initialPosition = new Position(10, 22);
            Command command1 = new Command(Direction.East, 2);
            Command command2 = new Command(Direction. North, 1);
            
            int minCommands = 0;
            int maxCommands = 10_000;
            int minX = -100_000;
            int maxX = 100_000;
            int minY = -100_000;
            int maxY = 100_000;

            IRunUseCase sut = new RunUseCase(minCommands, maxCommands, minX, maxX, minY, maxY);

            RunOutput actual = sut.Execute(initialPosition, new List<Command>() { command1, command2 });

        }
    }
}