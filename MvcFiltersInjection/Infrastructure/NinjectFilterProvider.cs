using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using Ninject;

namespace MvcFiltersInjection.Infrastructure
{
    public class NinjectFilterProvider : FilterAttributeFilterProvider
    {
        private readonly IKernel kernel;

        public NinjectFilterProvider(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public override IEnumerable<Filter> GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            var filters = base.GetFilters(controllerContext, actionDescriptor);

            foreach (var filter in filters)
            {
                kernel.Inject(filter.Instance);
            }

            return filters;
        }
    }
}