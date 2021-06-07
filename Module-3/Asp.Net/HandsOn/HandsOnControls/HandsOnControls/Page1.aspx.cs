using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnControls
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Page_Load() method is execute every time when page is loaded into the browser
            Response.Write("Hello Users"); 
        }

        protected void Click(object sender, EventArgs e)
        {
            //Redirect to Page2
            //Response.Redirect("Page2.aspx");
            //Response.Redirect("http://www.twitter.com");
            string name = txtName.Text;
            Response.Redirect("Page2.aspx?un=" + name);

           
        }
    }
}