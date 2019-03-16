using System;
using MrRobot.Core.Boundaries;

namespace MrRobot.ConsoleApp
{
    public sealed class Presenter : IResponseHandler<Core.Boundaries.Clean.Response>
    {
        public void Handle(Core.Boundaries.Clean.Response response)
        {
            Console.WriteLine($"=> Cleaned: { response.UniquePlacesCleaned }");
        }
    }
}