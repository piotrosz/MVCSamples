﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcNinjectApplication
{
    public class MyMessageService : IMessageService
    {
        public string TodaysMessage
        {
            get { return "Message from MyMessageService"; }
        }
    }
}