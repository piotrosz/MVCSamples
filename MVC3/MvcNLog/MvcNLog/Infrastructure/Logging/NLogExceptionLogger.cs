using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;
using System.Web.Mvc;
using System.Text;
using System.Web.Routing;
using System.Collections;

namespace MvcNLog.Infrastructure.Logging
{
    public class NLogExceptionLogger : IExceptionLogger
    {
        private static readonly string loggerName = "exception";
        private Logger logger;

        public NLogExceptionLogger()
        {
            logger = LogManager.GetLogger(loggerName);
        }

        public void Log(ExceptionContext context)
        {
            var logEvent = new LogEventInfo(LogLevel.Error, loggerName, context.Exception.Message);

            PrepareExceptionInfo(logEvent, context.Exception);
            PrepareRouteValuesInfo(logEvent, context.RouteData);
            PrepareHttpContextInfo(logEvent, context.HttpContext);

            if (context.RequestContext != null && context.RequestContext.HttpContext != null)
            {
                PrepareRequestInfo(logEvent, context.RequestContext.HttpContext.Request);
            }

            logger.Log(logEvent);
        }

        public void Log(Exception exception, HttpContextBase httpContext)
        {
            var logEvent = new LogEventInfo(LogLevel.Error, loggerName, exception.Message);

            PrepareExceptionInfo(logEvent, exception);
            PrepareHttpContextInfo(logEvent, httpContext);

            logger.Log(logEvent);
        }

        private void PrepareExceptionInfo(LogEventInfo logEvent, Exception exception)
        {
            if (exception == null)
            {
                return;
            }

            logEvent.Properties["exception"] = LogHelper.GetExceptionString(exception);
        }

        private void PrepareHttpContextInfo(LogEventInfo logEvent, HttpContextBase httpContext)
        {
            if (httpContext == null)
            {
                return;
            }

            logEvent.Properties["user"] = httpContext.User.Identity.Name;
        }

        private void PrepareRouteValuesInfo(LogEventInfo logEvent, RouteData routeData)
        {
            if (routeData == null)
            {
                return;
            }

            logEvent.Properties["controller"] = routeData.Values["controller"];
            logEvent.Properties["action"] = routeData.Values["action"];

            var routeValues = new StringBuilder();
            foreach (var value in routeData.Values)
            {
                routeValues.AppendFormat("[{0}={1}]", value.Key, value.Value);
            }

            logEvent.Properties["routevalues"] = routeValues.ToString();
        }

        private void PrepareRequestInfo(LogEventInfo logEvent, HttpRequestBase request)
        {
            if (request == null)
            {
                return;
            }

            logEvent.Properties["browser"] = request.Browser.Browser + " " + request.Browser.Version;
            logEvent.Properties["httpmethod"] = request.HttpMethod;
            logEvent.Properties["rawurl"] = request.RawUrl;
        }
    }
}