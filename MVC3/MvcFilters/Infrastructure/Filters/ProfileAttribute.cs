using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace MvcFilters.Infrastructure.Filters
{
     public class ProfileAttribute : FilterAttribute, IActionFilter 
     {
         private Stopwatch timer;

         public void OnActionExecuting(ActionExecutingContext filterContext)
         {
             timer = Stopwatch.StartNew();
         }

         public void OnActionExecuted(ActionExecutedContext filterContext)
         {
             timer.Stop();

             if (filterContext.Exception == null)
             {
                 filterContext.HttpContext.Response.Write(string.Format("Action method elapsed time: {0}", timer.Elapsed.TotalSeconds));
             }

             //filterContext.ActionDescriptor. // Szczegóły metody akcji
             //filterContext.Canceled // true, jeśli akcja została anulowana przez inny filtr
             //filterContext.Exception
             //filterContext.ExceptionHandled
             //filterContext.Result // jesli jakas wartosc nie nullowa, to anulowanie
         }
     }
}