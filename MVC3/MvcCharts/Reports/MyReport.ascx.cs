using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MvcCharts.Infrastructure;
using System.IO;

namespace MvcCharts.Reports
{
    public partial class MyReport : System.Web.UI.UserControl, IReportControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public object DataSource
        {
            set
            {
                Chart1.DataSource = value;
            }
        }

        public override void DataBind()
        {
            base.DataBind();
            Chart1.DataBind();
        }

        public void SaveChartImage(Stream stream)
        {
            Chart1.SaveImage(stream);
        }
    }
}