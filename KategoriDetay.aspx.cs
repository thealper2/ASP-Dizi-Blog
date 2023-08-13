﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KategoriDetay : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
        var bloglar = db.TBLBLOG.Where(x => x.BLOGKATEGORI == id).ToList();
        Repeater1.DataSource = bloglar;
        Repeater1.DataBind();

        var bloglar3 = db.TBLBLOG.Take(5).ToList();
        Repeater2.DataSource = bloglar3;
        Repeater2.DataBind();
    }
}