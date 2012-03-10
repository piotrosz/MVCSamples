using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Globalization;

namespace MvcRouteConstraints.Infrastructure
{
    public class YearRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if ((routeDirection == RouteDirection.IncomingRequest) && (parameterName.ToLower(CultureInfo.InvariantCulture) == "year"))
            {
                try
                {
                    int year = Convert.ToInt32(values["year"]);

                    if ((year >= 1900) && (year <= 2100))
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