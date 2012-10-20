using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcNinjectApplication
{
    public interface IMessageService
    {
        string TodaysMessage { get; }
    }
}