using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Yorumlar : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["KULLANICI"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        var yorum = (from x in db.TBLYORUM
                     select new
                     {
                         x.YORUMID,
                         x.KULLANICIAD,
                         x.MAIL,
                         x.TBLBLOG.BLOGBASLIK
                     }).ToList();

        Repeater1.DataSource = yorum;
        Repeater1.DataBind();
    }
}