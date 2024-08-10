<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitim.aspx.cs" Inherits="ResumeWebSite.AdminEgitim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form id="Form1" runat="server">
  
  
  <table class="table table-bordered">
      <thead>
          <tr>
              <th>ID</th>
              <th>Başlık</th>
              <th>Altbaşlık</th>
              <th>Açıklama</th>
              <th>Tarih</th>
              <th>İşlemler</th>
          </tr>
      </thead>
      <tbody>
          <asp:Repeater ID="Repeater1" runat="server">
              <ItemTemplate>
                  <tr>
                      <td><%# Eval("ID") %></td>
                      <td><%# Eval("BASLIK") %></td>
                      <td><%# Eval("ALTBASLIK") %></td>
                      <td><%# Eval("ACIKLAMA") %></td>
                      <td><%# Eval("TARIH") %></td>   
                      <td>
                          <asp:HyperLink NavigateUrl='<%#"AdminEgitimSil.aspx?ID="+ Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger" >Sil</asp:HyperLink>
                          <asp:HyperLink NavigateUrl='<%#"AdminEgitimGuncelle.aspx?ID="+ Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink>
                      </td>
                  </tr>
              </ItemTemplate>
          </asp:Repeater>
      </tbody>
  </table>
     <asp:HyperLink NavigateUrl="~/AdminEgitimEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-primary">Eğitim Ekle</asp:HyperLink>
     </form>


</asp:Content>
