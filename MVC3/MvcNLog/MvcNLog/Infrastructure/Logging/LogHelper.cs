using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Collections;

namespace MvcNLog.Infrastructure.Logging
{
    public class LogHelper
    {
        public static string GetExceptionString(Exception exception)
        {
            var info = new StringBuilder();
            string indent = "";

            for (Exception eCurrent = exception; eCurrent != null; eCurrent = eCurrent.InnerException)
            {
                info.AppendFormat("{0}Type: {1}", indent, eCurrent.GetType());
                info.AppendLine();
                info.AppendFormat("{0}Message: {1}", indent, eCurrent.Message);
                info.AppendLine();
                info.AppendFormat("{0}Source: {1}", indent, eCurrent.Source);
                info.AppendLine();
                if (!string.IsNullOrEmpty(eCurrent.HelpLink))
                {
                    info.AppendFormat("{0}Help link: {1}", indent, eCurrent.HelpLink);
                    info.AppendLine();
                }

                if (eCurrent.Data != null && eCurrent.Data.Count > 0)
                {
                    info.AppendFormat("{0}Data: ", indent);

                    foreach (DictionaryEntry entry in eCurrent.Data)
                    {
                        info.AppendFormat("{0}[{1}, {2}]", indent, entry.Key, entry.Value);
                        info.AppendLine();
                    }

                    info.AppendLine();
                }

                info.AppendFormat("{0}Target site: {1}", indent, eCurrent.TargetSite);
                info.AppendLine();
                info.AppendFormat("{0}Stack trace:\n{1}", indent, eCurrent.StackTrace);
                info.AppendLine();

                indent += "    ";
                if (eCurrent.InnerException != null)
                {
                    info.AppendFormat("{0}Inner exception:", indent);
                    info.AppendLine();
                }
            }

            return info.ToString();
        }

    }
}