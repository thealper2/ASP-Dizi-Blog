using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace DiziSite
{
    public partial class Default : System.Web.UI.Page
    {
        BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            var bloglar = db.TBLBLOG.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();
        }
    }
}