using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_istatistik : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Kullanici"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        LblBlog.Text = db.TBLBLOG.Count().ToString();
        LblYorum.Text = db.TBLYORUM.Count().ToString();
        LblFlim.Text = db.TBLBLOG.Where(i => i.BLOGTUR == 2).Count().ToString();
        LblAnimasyon.Text = db.TBLBLOG.Where(x => x.TBLTUR.TURAD == "Animasiyon").Count().ToString();
        LblDizi.Text = db.TBLBLOG.Where(i => i.TBLTUR.TURAD == "Dizi").Count().ToString();
        LblYorumBlog.Text = db.TBLBLOG.Where(y => y.BLOGID == (db.TBLYORUM.GroupBy(x => x.YORUMBLOG)
        .OrderByDescending(x => x.Count()).Select(z => z.Key).FirstOrDefault())).Select(k => k.BLOGBASLIK).FirstOrDefault();
    }
}