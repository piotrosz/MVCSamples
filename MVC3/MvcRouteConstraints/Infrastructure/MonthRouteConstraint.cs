using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Globalization;

namespace MvcRouteConstraints.Infrastructure
{
    public class MonthRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if ((routeDirection == RouteDirection.IncomingRequest) && (parameterName.ToLower(CultureInfo.InvariantCulture) == "month"))
            {
                try
                {
                    int month = Convert.ToInt32(values["month"]);
                    if ((month >= 1) && (month <= 12))
                        return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}