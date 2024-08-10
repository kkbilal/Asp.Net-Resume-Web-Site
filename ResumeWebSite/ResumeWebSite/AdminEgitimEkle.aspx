<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimEkle.aspx.cs" Inherits="ResumeWebSite.AdminEgitimEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

        <form id="Form1" runat="server">
    <div class="form-group">
     <div>
         <asp:Label ID="Label1" runat="server" Text="Başlık"></asp:Label>
         <asp:TextBox ID="txtbaslik" runat="server" CssClass="form-control"></asp:TextBox>
     </div>
        <br />
     <div>
         <asp:Label ID="Label2" runat="server" Text="Alt Başlık"></asp:Label>
         <asp:TextBox ID="txtaltbaslik" runat="server" CssClass="form-control"></asp:TextBox>
     </div><br />
     <div>
         <asp:Label ID="Label3" runat="server" Text="Açıklama"></asp:Label>
         <asp:TextBox ID="txtaciklama" runat="server" CssClass="form-control" ></asp:TextBox>
     </div><br />
     <div>
         <asp:Label ID="Label4" runat="server" Text="Tarih"></asp:Label>
         <asp:TextBox ID="txttarih" runat="server" CssClass="form-control"></asp:TextBox>
     </div><br />
     
    
        <asp:Button ID="Button1" runat="server" Text="Kaydet" Class="btn btn-success" OnClick="Button1_Click" />
</div>

</form>
</asp:Content>
