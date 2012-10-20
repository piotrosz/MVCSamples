using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Globalization;

namespace MvcRouteConstraints.Infrastructure
{
    public class DayRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if ((routeDirection == RouteDirection.IncomingRequest) && (parameterName.ToLower(CultureInfo.InvariantCulture) == "day"))
            {
                try
                {
                    int month = Convert.ToInt32(values["month"]);
                    int day = Convert.ToInt32(values["day"]);

                    if (day < 1)
                        return false;

                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if (day <= 31) return true;
                            break;
                        case 2:
                            if (day <= 28) return true;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (day <= 30) return true;
                            break;
                    }
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