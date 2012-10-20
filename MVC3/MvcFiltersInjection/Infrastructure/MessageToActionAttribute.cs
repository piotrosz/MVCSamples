using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using Ninject;

namespace MvcFiltersInjection.Infrastructure
{
    public class MessageToActionAttribute : ActionFilterAttribute
    {
        [Inject]
        public IMessageService MessageService { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var actionName = filterContext.ActionDescriptor.ActionName;
            filterContext.Controller.ViewBag.FilterMessage = MessageService.GetMessageForAction(actionName);
        }
    }
}