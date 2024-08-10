<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimGuncelle.aspx.cs" Inherits="ResumeWebSite.AdminEgitimGuncelle" %>
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
         <asp:Label ID="Label1" runat="server" Text="Başlık"></asp:Label>
         <asp:TextBox ID="txtBaslık" runat="server" CssClass="form-control"></asp:TextBox>
     </div>
        <br />
     <div>
         <asp:Label ID="Label2" runat="server" Text="Alt Başlık"></asp:Label>
         <asp:TextBox ID="txtAltbaslık" runat="server" CssClass="form-control"></asp:TextBox>
     </div><br />
     <div>
         <asp:Label ID="Label3" runat="server" Text="Açıklama"></asp:Label>
         <asp:TextBox ID="txtacıklama" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine" ></asp:TextBox>
     </div><br />
     <div>
         <asp:Label ID="Label4" runat="server" Text="Tarih"></asp:Label>
         <asp:TextBox ID="txttarıh" runat="server" CssClass="form-control"></asp:TextBox>
     </div><br />
     
    
        <asp:Button ID="Button1" runat="server" Text="Güncelle" Class="btn btn-primary" OnClick="Button1_Click1" />
</div>

</form>


</asp:Content>
