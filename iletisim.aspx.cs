using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class iletisim : System.Web.UI.Page
{
    BlogDiziDBEntities2 db = new BlogDiziDBEntities2();
    protected void Page_Load(object sender, EventArgs e)
    {
        Repeater1.DataSource = db.TBLHAKKIMIZDA.ToList();
        Repeater1.DataBind();
    }

    protected void Btniletisim_Click(object sender, EventArgs e)
    {
        TBLILETISIM t = new TBLILETISIM();
        t.ADSOYAD = TxtAd.Text;
        t.MAIL = TxtMail.Text;
        t.TELEFON = TxtTelefon.Text;
        t.KONU = TxtKonu.Text;
        t.MESAJ = TxtMesaj.Text;
        db.TBLILETISIM.Add(t);
        db.SaveChanges();
    }
}