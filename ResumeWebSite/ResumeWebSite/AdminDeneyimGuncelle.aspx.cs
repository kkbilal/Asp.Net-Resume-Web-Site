using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResumeWebSite
{
    public partial class DeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(Request.QueryString["ID"]);
                txtId.Enabled = false;
                txtId.Text = x.ToString();
                if (Page.IsPostBack == false)
                {
                    DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
                    txtBaslık.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
                    txtAltbaslık.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                    txtacıklama.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                    txttarıh.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].TARIH;
                }
            }
            catch
            {   }
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt1 = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            dt1.DeneyimGuncelle(txtBaslık.Text,txtAltbaslık.Text,txtacıklama.Text,txttarıh.Text,Convert.ToInt16(txtId.Text));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}