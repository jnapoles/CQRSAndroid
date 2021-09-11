using System;
using Android.App;
using Android.Runtime;
using Java.IO;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace AndroidDemo
{
    [Application]
    public class Program : Application
    {
        public Program(IntPtr javaReference, JniHandleOwnership transfer): base(javaReference,transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();


            Injection.Mediator = new DInjection.DInjection(new ServiceCollection()).GetService<IMediator>();
        }
    }
}
