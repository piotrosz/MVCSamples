using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using FakeItEasy;
using MvcPagedGrid.Domain.Abstract;
using MvcPagedGrid.Domain.Entities;
using MvcPagedGrid.Domain.Concrete;

namespace MvcPagedGrid.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
            ? null
            : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            //var mockRepository = A.Fake<INoteRepository>();
            //A.CallTo(() => mockRepository.Notes).Returns(new List<Note>()
            //{
            //    new Note { Id = 1, Content = "Notatka 1" },
            //    new Note { Id = 2, Content = "Notatka 2" }
            //}.AsQueryable());

            //ninjectKernel.Bind<INoteRepository>().ToConstant(mockRepository);

            ninjectKernel.Bind<INoteRepository>().To<EFNoteRepository>();
        }
    }
}
