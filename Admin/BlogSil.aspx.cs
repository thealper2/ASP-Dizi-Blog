﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_BlogSil : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["BLOGID"]);
        var blog = db.TBLBLOG.Find(x);
        db.TBLBLOG.Remove(blog);
        db.SaveChanges();
        Response.Redirect("Bloglar.aspx");
    }
}