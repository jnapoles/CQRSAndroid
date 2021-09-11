using System;
using ApplicationStandard;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DInjection
{
    public class DInjection
    {
        IServiceProvider ServiceProvider;
        public DInjection(IServiceCollection collection)
        {
            ServiceProvider = collection.AddMediatR(typeof(Load)).BuildServiceProvider();
        }

        public T GetService<T>()
        {
            return ServiceProvider.GetService<T>();
        }
    }
}
