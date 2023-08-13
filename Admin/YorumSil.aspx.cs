using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_YorumSil : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        int i = Convert.ToInt32(Request.QueryString["YORUMID"]);

        var yorum = db.TBLYORUM.Find(i);
        db.TBLYORUM.Remove(yorum);
        db.SaveChanges();
        Response.Redirect("Yorumlar.aspx");
    }
}