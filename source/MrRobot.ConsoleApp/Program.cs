using System;
using MrRobot.Domain.Cleaning.Run;

namespace MrRobot.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCommands = Convert.ToInt32(Console.ReadLine());
            string positionText = Console.ReadLine();
            Position initialPosition = new Position(
                Convert.ToInt32(positionText.Split(' ')[0]), 
                Convert.ToInt32(positionText.Split(' ')[1]));

            Command[] commands = new Command[numCommands];
            for (int i = 0; i < commands.Length; i++)
            {
                string commandText = Console.ReadLine();

                Direction direction = Direction.North;
                
                if (commandText.Split(' ')[0] == "N")
                    direction = Direction.North;
                
                if (commandText.Split(' ')[0] == "S")
                    direction = Direction.South;
                
                if (commandText.Split(' ')[0] == "E")
                    direction = Direction.East;

                if (commandText.Split(' ')[0] == "W")
                    direction = Direction.West;
                
                commands[i] = new Command(
                    Convert.ToInt32(commandText.Split(' ')[1]),
                    direction);
            }

            IRunUseCase run = new RunUseCase();
            RunOutput output = run.Execute(initialPosition, commands);

            Console.WriteLine($"=> Cleaned: {output.UniquePlacesCleaned}");
        }
    }
}
