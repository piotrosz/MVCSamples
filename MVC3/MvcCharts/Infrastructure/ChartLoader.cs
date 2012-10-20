using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.IO;
using System.Web.UI;

namespace MvcCharts.Infrastructure
{
    public static class ChartLoader
    {
        public static void SaveChartImage(string controlLocation, IEnumerable data, Stream stream)
        {
            using (var page = new Page())
            using (var control = (IReportControl)
                   page.LoadControl("~/Reports/" + controlLocation))
            {
                control.DataSource = data;
                control.DataBind();
                control.SaveChartImage(stream);
            }
        }
    }
}