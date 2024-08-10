using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResumeWebSite
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
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
                    DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
                    txtyetenek.Text = dt.YetenekGetir(Convert.ToInt16(x))[0].YETENEK;
                    
                }
            }
            catch
            { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt1 = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            dt1.YetenekGuncelle(txtyetenek.Text, Convert.ToInt16(txtId.Text));
            Response.Redirect("AdminYetenek.aspx");
        }
    }
}