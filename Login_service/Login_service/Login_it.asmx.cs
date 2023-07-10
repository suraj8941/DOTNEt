using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Login_service
{
    /// <summary>
    /// Summary description for Login_it
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Login_it : System.Web.Services.WebService
    {
        String user = "Suraj";
        int password = 1234;

        [WebMethod]
        public bool Login_i(String username, int password)
        {
            String  user_test = "Suraj";
            int pass_test = 1234;
            if (username == user_test && password==pass_test)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
        
    }
}
