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
            
            int expectedUniquePlacesCleaned = 4;

            IRunUseCase sut = new RunUseCase();
            RunOutput actual = sut.Execute(initialPosition, new List<Command>() { command1, command2 });

            Assert.Equal(expectedUniquePlacesCleaned, actual.UniquePlacesCleaned);
        }
    }
}