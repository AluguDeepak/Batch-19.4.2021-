using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnControls
{
    public partial class Regiser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register(object sender, EventArgs e)
        {
            //Write code to add user details to user-table
            //Add Details to back end table.
            lblMsg.Text = "Register Successfull";
            Response.Write(ddlCountry.Text);
        }
    }
}