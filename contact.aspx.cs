﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ICT272_assessment1
{
  public partial class Contact : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
      // save data as a session
      Session["value"] = nameBox.Text;

      // send data
      Response.Redirect("Thankyou.aspx");

    }
  }
}