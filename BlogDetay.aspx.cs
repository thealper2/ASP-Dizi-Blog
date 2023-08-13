using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;


public partial class BlogDetay : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["BlOGID"]);
        var blok = db.TBLBLOG.Where(x => x.BLOGID == id).ToList();
        Repeater1.DataSource = blok;
        Repeater1.DataBind();

        var blok2 = db.TBLYORUM.Where(x => x.YORUMBLOG == id).ToList();
        Repeater2.DataSource = blok2;
        Repeater2.DataBind();
    }

    protected void BtnYorum_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["BLOGID"]);
        TBLYORUM y = new TBLYORUM();
        y.KULLANICIAD = TxtAd.Text;
        y.MAIL = TxtMail.Text;
        y.YORUMICERIK = TxtYorum.Text;
        y.YORUMBLOG = id;
        db.TBLYORUM.Add(y);
        db.SaveChanges();
        Response.Redirect("BlogDetay.aspx?BLOGID=" + id);
    }
}