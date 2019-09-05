using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4_9._1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btn1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Server.MapPath("Images")))
            {
                Directory.CreateDirectory(Server.MapPath("Images"));
            }


            string imageUrl = (Server.MapPath("Images") + "\\" + img.FileName);
            string dbpathImage = "~/Images/" + img.FileName;
            img.SaveAs(imageUrl);
        }
    }
}