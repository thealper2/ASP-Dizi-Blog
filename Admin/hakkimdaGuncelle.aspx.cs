using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_hakkimdaGuncelle : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        int i = int.Parse(Request.QueryString["ID"]);

        if (IsPostBack == false)
        {
            var Guncelle = (from x in db.TBLHAKKIMIZDA
                            select new
                            {
                                x.iletisimAciklama,
                                x.ACIKLAMA
                            }).ToList();

            var deger = db.TBLHAKKIMIZDA.Find(i);
            TxtIletisim.Text = deger.iletisimAciklama;
            TxtHakkimda.Text = deger.ACIKLAMA;
        }
    }

    protected void BtnKayit_Click(object sender, EventArgs e)
    {
        int y = int.Parse(Request.QueryString["ID"]);
        var blog = db.TBLHAKKIMIZDA.Find(y);
        blog.iletisimAciklama = TxtIletisim.Text;
        blog.ACIKLAMA = TxtHakkimda.Text;
        db.SaveChanges();
        Response.Redirect("hakkimda.aspx");
    }
}