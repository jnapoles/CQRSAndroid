using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Application
{
    public class PingHandler : IRequestHandler<Ping, string>
    {
        public async Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return await Task.FromResult("Pong!!!!");
        }
    }
}
