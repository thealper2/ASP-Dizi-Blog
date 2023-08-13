using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Mesajlar : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["KULLANICI"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        var x = db.TBLILETISIM.ToList();
        Repeater1.DataSource = x;
        Repeater1.DataBind();
    }
}