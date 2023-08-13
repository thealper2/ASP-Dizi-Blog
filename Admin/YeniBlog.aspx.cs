using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_YeniBlog : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["KULLANICI"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

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
        }
    }

    protected void BtnKayit_Click(object sender, EventArgs e)
    {
        TBLBLOG t = new TBLBLOG();
        t.BLOGBASLIK = TxtBaslik.Text;
        t.BLOGTARIH = DateTime.Parse(TxtTarih.Text);
        t.BLOGGORSEL = TxtGorsel.Text;
        t.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
        t.BLOGKATEGORI = byte.Parse(DropDownList2.SelectedValue);
        t.BLOGICERIK = TxtIcerik.Text;
        db.TBLBLOG.Add(t);
        db.SaveChanges();
        Response.Redirect("Bloglar.aspx");
    }
}