﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminSertifikaGuncelle.aspx.cs" Inherits="ResumeWebSite.AdminSertifikaGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
                <form id="Form1" runat="server">
    <div class="form-group">
          <div>
      <asp:Label ID="Label5" runat="server" Text="ID"></asp:Label>
      <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
  </div>
     <div>
         <asp:Label ID="Label1" runat="server" Text="Sertifika"></asp:Label>
         <asp:TextBox ID="txtsertifika" runat="server" CssClass="form-control"></asp:TextBox>
     </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Güncelle" Class="btn btn-primary" OnClick="Button1_Click" />
</div>

</form>
</asp:Content>
