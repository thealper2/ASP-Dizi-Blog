using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hakkimda : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        Repeater1.DataSource = db.TBLHAKKIMIZDA.ToList();
        Repeater1.DataBind();
    }
}