﻿using System;
using System.Linq;

namespace DynamicCV
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCVEntities db = new DbCVEntities();
            Repeater1.DataSource = db.TBLHAKKIMDAs.ToList();
            Repeater1.DataBind(); 
            Repeater2.DataSource = db.TBLHAKKIMDAs.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.TBLHAKKIMDAs.ToList();
            Repeater3.DataBind();     
            Repeater4.DataSource = db.TBL_YETENEKLER.ToList();
            Repeater4.DataBind();
            Repeater5.DataSource = db.TBL_CALISMALARIM.ToList();
            Repeater5.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DbCVEntities db = new DbCVEntities();
            TBL_ILETISIM t = new TBL_ILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;
            db.TBL_ILETISIM.Add(t);
            db.SaveChanges();
        }
    }
}