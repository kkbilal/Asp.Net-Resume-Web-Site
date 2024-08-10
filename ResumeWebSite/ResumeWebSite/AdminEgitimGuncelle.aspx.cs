using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResumeWebSite
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
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
                    DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
                    txtBaslık.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].BASLIK;
                    txtAltbaslık.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                    txtacıklama.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                    txttarıh.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].TARIH;
                }
            }
            catch
            { }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt1 = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt1.EgitimGuncelle(txtBaslık.Text, txtAltbaslık.Text, txtacıklama.Text, txttarıh.Text, Convert.ToInt16(txtId.Text));
            Response.Redirect("AdminEgitim.aspx");
        }
    }
}