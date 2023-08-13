using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnGiris_Click1(object sender, EventArgs e)
    {
        var sorgu = from x in db.TBLADMIN where x.KULLANICI == TxtAd.Text && x.SIFRE == TxtSifre.Text select x;
        if (sorgu.Any())
        {
            Session.Add("Kullanici", TxtAd.Text);
            Response.Redirect("/Admin/Bloglar.aspx");
        }
        else
        {
            Response.Write("Hata");
        }
    }
}