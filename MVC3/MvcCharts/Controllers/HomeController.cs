using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace MvcCharts.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var bytes = new Chart(width: 400, height: 200)
                .AddSeries(
                    chartType: "bar",
                    xValue: new[] { "Math", "English", "Computer", "Urdu" },
                    yValues: new[] { "60", "70", "68", "88" })
                .GetBytes("png");

            return File(bytes, "image/png");
        }

        public ActionResult MyChart()
        {
            string myTheme =
                @"<Chart BackColor=""Transparent"">
                    <ChartAreas>
                        <ChartArea Name=""Default"" BackColor=""Transparent""></ChartArea>
                    </ChartAreas>
                </Chart>";

            var bytes = new Chart(width: 400, height: 200, theme: myTheme)
            .AddSeries(
                chartType: "bar",
                xValue: new[] { "Math", "English", "Computer", "Urdu" },
                yValues: new[] { "60", "70", "68", "88" })
            .GetBytes("png");

            return File(bytes, "image/png");
        }
    }
}