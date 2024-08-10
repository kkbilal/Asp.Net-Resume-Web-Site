﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ResumeWebSite
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-82RLRPM\SQLEXPRESS;Initial Catalog=ResumeDB;Integrated Security=True;TrustServerCertificate=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLADMIN where KULLANICI=@P1 and SIFRE=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1",TextBox1.Text);
            komut.Parameters.AddWithValue("@P2", TextBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();  
            if (dr.Read())
            {
                Response.Redirect("Hakkimda.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı");
            }
            baglanti.Close();
        }
    }
}