<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="chitietsanpham.aspx.cs" Inherits="ShopNhaViet.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="chitietsanpham" runat="server"
        ItemType="ShopNhaViet.Models.SanPham" SelectMethod ="GetSanPhams"
         RenderOuterTable="false">
         <ItemTemplate>
         <div>
         <h1><%#:Item.TenSanPham %></h1>
         </div>
         <br />
         <table>
         <tr>
         <td>
         <img src="/Images/<%#:Item.HinhAnh %>"
         style="border:solid; height:225px" alt="<%#:Item.TenSanPham %>"/>
         </td>
         <td>&nbsp;</td>
         <td style="vertical-align: top; text-align:left;">
         <b>Mô Tả:</b><br /><%#:Item.MoTa %>
         <br />
         <span><b>Gia:</b>&nbsp;<%#: String.Format("{0:c}",Item.GiaTien)
        %></span>
         <br />
         <span><b>Stt:</b>&nbsp;<%#:Item.SanPhamID %></span>
         <br />
         </td>
         </tr>
         </table>
         </ItemTemplate>
         </asp:FormView>
</asp:Content>
