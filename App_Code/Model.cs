﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class sysdiagrams
{
    public string name { get; set; }
    public int principal_id { get; set; }
    public int diagram_id { get; set; }
    public Nullable<int> version { get; set; }
    public byte[] definition { get; set; }
}

public partial class TBLADMIN
{
    public int ID { get; set; }
    public string KULLANICI { get; set; }
    public string SIFRE { get; set; }
}

public partial class TBLBLOG
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TBLBLOG()
    {
        this.TBLYORUM = new HashSet<TBLYORUM>();
    }

    public int BLOGID { get; set; }
    public string BLOGBASLIK { get; set; }
    public string BLOGICERIK { get; set; }
    public Nullable<System.DateTime> BLOGTARIH { get; set; }
    public string BLOGGORSEL { get; set; }
    public Nullable<byte> BLOGTUR { get; set; }
    public Nullable<byte> BLOGKATEGORI { get; set; }

    public virtual TBLKATEGORI TBLKATEGORI { get; set; }
    public virtual TBLTUR TBLTUR { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TBLYORUM> TBLYORUM { get; set; }
}

public partial class TBLHAKKIMIZDA
{
    public byte ID { get; set; }
    public string ACIKLAMA { get; set; }
    public string iletisimAciklama { get; set; }
}

public partial class TBLILETISIM
{
    public int MESAJID { get; set; }
    public string ADSOYAD { get; set; }
    public string MAIL { get; set; }
    public string TELEFON { get; set; }
    public string KONU { get; set; }
    public string MESAJ { get; set; }
}

public partial class TBLKATEGORI
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TBLKATEGORI()
    {
        this.TBLBLOG = new HashSet<TBLBLOG>();
    }

    public byte KATEGORIID { get; set; }
    public string KATEGORIAD { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TBLBLOG> TBLBLOG { get; set; }
}

public partial class TBLTUR
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TBLTUR()
    {
        this.TBLBLOG = new HashSet<TBLBLOG>();
    }

    public byte TURID { get; set; }
    public string TURAD { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TBLBLOG> TBLBLOG { get; set; }
}

public partial class TBLYORUM
{
    public int YORUMID { get; set; }
    public string KULLANICIAD { get; set; }
    public string MAIL { get; set; }
    public string YORUMICERIK { get; set; }
    public Nullable<int> YORUMBLOG { get; set; }

    public virtual TBLBLOG TBLBLOG { get; set; }
}
