using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResumeWebSite
{
    public partial class AdminSertifikaGuncelle : System.Web.UI.Page
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
                    DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
                    txtsertifika.Text = dt.SertifikaGetir(Convert.ToInt16(x))[0].ODUL;

                }
            }
            catch
            { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt1 = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            dt1.SertifikaGuncelle(txtsertifika.Text, Convert.ToInt16(txtId.Text));
            Response.Redirect("AdminSertifika.aspx");
        }
    }
}