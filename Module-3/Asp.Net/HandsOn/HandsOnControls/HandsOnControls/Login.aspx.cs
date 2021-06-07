using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnControls
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Validate(object sender, EventArgs e)
        {
            //Write data-access code here(Ado.net)
            string uname = txtUname.Text;
            string pwd = txtPwd.Text;
            if (uname == "Rohan" && pwd == "12345")
            {
                Response.Redirect("Welcome.aspx?uname=" + uname);
            }
            else
                lblMsg.Text = "Invalid Credentials";
        }
    }
}