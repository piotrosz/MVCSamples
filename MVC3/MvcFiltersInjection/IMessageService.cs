using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFiltersInjection
{
    public interface IMessageService
    {
        string GetMessageForAction(string actionName);
    }
}