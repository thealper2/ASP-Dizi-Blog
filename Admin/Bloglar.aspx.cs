using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Bloglar : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Kullanici"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (IsPostBack == false)
        {
            var tur = (from x in db.TBLBLOG
                       select new
                       {
                           x.BLOGID,
                           x.BLOGBASLIK,
                           x.BLOGTARIH,
                           x.TBLTUR.TURAD,
                           x.TBLKATEGORI.KATEGORIAD
                       }).ToList();

            Repeater1.DataSource = tur;
            Repeater1.DataBind();
        }
    }
}