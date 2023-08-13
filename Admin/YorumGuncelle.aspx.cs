using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_YorumGuncelle : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        int i = int.Parse(Request.QueryString["YORUMID"]);

        if (IsPostBack == false)
        {
            var tur = (from x in db.TBLYORUM
                       select new
                       {
                           x.KULLANICIAD,
                           x.YORUMICERIK
                       }).ToList();

            var deger = db.TBLYORUM.Find(i);
            TxtBaslik.Text = deger.TBLBLOG.BLOGBASLIK;
            TxtKullanici.Text = deger.KULLANICIAD;
            TxtIcerik.Text = deger.YORUMICERIK;
        }
    }

    protected void BtnKayit_Click(object sender, EventArgs e)
    {
        int i = Convert.ToInt32(Request.QueryString["YORUMID"]);

        var yorum = db.TBLYORUM.Find(i);
        yorum.KULLANICIAD = TxtKullanici.Text;
        yorum.YORUMICERIK = TxtIcerik.Text;
        db.SaveChanges();
        Response.Redirect("Yorumlar.aspx");
    }
}