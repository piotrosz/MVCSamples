using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFiltersInjection
{
    public class MyMessageService : IMessageService
    {
        public string GetMessageForAction(string actionName)
        {
            return string.Format("Action name is: {0}", actionName);
        }
    }
}