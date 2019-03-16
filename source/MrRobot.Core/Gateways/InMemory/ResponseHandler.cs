namespace MrRobot.Core.Gateways.InMemory
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using MrRobot.Core.Boundaries.Clean;
    using MrRobot.Core.Boundaries;

    public sealed class ResponseHandler : IResponseHandler<Boundaries.Clean.Response>
    {
        public Collection<Boundaries.Clean.Response> CleanedItems { get; }

        public ResponseHandler()
        {
            CleanedItems = new Collection<Boundaries.Clean.Response>();
        }

        public void Handle(Response response)
        {
            CleanedItems.Add(response);
        }
    }
}