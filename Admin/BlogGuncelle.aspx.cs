using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_BlogGuncelle : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        int i = int.Parse(Request.QueryString["BLOKID"]);

        if (IsPostBack == false)
        {
            var tur = (from x in db.TBLTUR
                       select new
                       {
                           x.TURAD,
                           x.TURID
                       }).ToList();

            DropDownList1.DataSource = tur;
            DropDownList1.DataBind();

            var kategori = (from x in db.TBLKATEGORI
                            select new
                            {
                                x.KATEGORIAD,
                                x.KATEGORIID
                            }).ToList();

            DropDownList2.DataSource = kategori;
            DropDownList2.DataBind();

            var deger = db.TBLBLOG.Find(i);
            TxtBaslik.Text = deger.BLOGBASLIK;
            TxtTarih.Text = deger.BLOGTARIH.ToString();
            TxtGorsel.Text = deger.BLOGGORSEL;
            TxtIcerik.Text = deger.BLOGICERIK;

            DropDownList1.SelectedValue = deger.BLOGTUR.ToString();
            DropDownList2.SelectedValue = deger.BLOGKATEGORI.ToString();
        }
    }

    protected void BtnKayit_Click(object sender, EventArgs e)
    {
        int y = int.Parse(Request.QueryString["BLOKID"]);
        var blog = db.TBLBLOG.Find(y);
        blog.BLOGBASLIK = TxtBaslik.Text;
        blog.BLOGTARIH = DateTime.Parse(TxtTarih.Text);
        blog.BLOGGORSEL = TxtGorsel.Text;
        blog.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
        blog.BLOGKATEGORI = byte.Parse(DropDownList1.SelectedValue);
        blog.BLOGICERIK = TxtIcerik.Text;
        db.SaveChanges();
        Response.Redirect("Bloglar.aspx");
    }
}