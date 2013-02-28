using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcNLog.Infrastructure.Logging
{
    public interface IExceptionLogger
    {
        void ErrorException(string message, Exception exception /* TODO additional info*/);
    }
}
