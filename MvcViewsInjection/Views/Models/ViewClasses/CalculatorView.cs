using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using Ninject;

namespace MvcViewsInjection.Views.Models.ViewClasses
{
    public class CalculatorView : WebViewPage
    {
        [Inject]
        public ICalculator Calculator { get; set; }

        public override void Execute()
        {
        }
    }
}