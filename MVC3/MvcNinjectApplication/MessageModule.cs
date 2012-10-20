using System;
using Ninject.Modules;

namespace MvcNinjectApplication
{
    public class MessageModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMessageService>().To<MyMessageService>();
        }
    }
}