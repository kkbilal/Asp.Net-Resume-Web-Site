using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResumeWebSite
{
    public partial class AdminHobiGuncelle : System.Web.UI.Page
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
                    DataSet1TableAdapters.TBLHOBILERTableAdapter dt = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
                    txthobi.Text = dt.HobiGetir(Convert.ToInt16(x))[0].HOBI;

                }
            }
            catch
            { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHOBILERTableAdapter dt1 = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            dt1.HobiGuncelle(txthobi.Text, Convert.ToInt16(txtId.Text));
            Response.Redirect("AdminHobi.aspx");
        }
    }
    
}