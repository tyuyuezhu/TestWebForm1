﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace TestWebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ccd = new CounterCreationData("logins", "sdfs", PerformanceCounterType.NumberOfItems32);
            ccd.
        }
    }
}