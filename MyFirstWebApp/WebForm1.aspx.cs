using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void login_it_Click(object sender, EventArgs e)
        {
            if (userdaal.Text == "Suraj" && passwordbata.Text == "1234")
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                //lblMessage.Text = "Invalid username and password";
            }

        }

        protected void cancel_it_Click(object sender, EventArgs e)
        {
            userdaal.Text = "";
            passwordbata.Text = "";
            userdaal.Focus();
        }

        
    }
}