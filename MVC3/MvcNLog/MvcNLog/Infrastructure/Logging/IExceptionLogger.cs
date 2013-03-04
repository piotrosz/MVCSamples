using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcNLog.Infrastructure.Logging
{
    public interface IExceptionLogger
    {
        void Log(ExceptionContext exceptionContext);
        void Log(Exception exception, HttpContextBase httpContext);
    }
}