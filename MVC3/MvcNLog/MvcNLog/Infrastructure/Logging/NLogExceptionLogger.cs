using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcNLog.Infrastructure.Logging
{
    public class NLogExceptionLogger : IExceptionLogger
    {
        private Logger logger;

        public NLogExceptionLogger()
        {
            //logger = LogManager.GetCurrentClassLogger();
            logger = LogManager.GetLogger("exceptions");
        }

        public void ErrorException(string message, Exception exception)
        {

//            LogEventInfo theEvent = new LogEventInfo(LogLevel.Debug, "", "Pass my custom value");
//            theEvent.Properties["MyValue"] = "My custom string";

//            log.Log(theEvent);
//            ...
//            and in your NLog.config file:

//${event-context:item=MyValue} -- renders "My custom string"

            logger.ErrorException(message, exception);
        }
    }
}
