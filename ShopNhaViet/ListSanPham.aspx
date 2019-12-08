<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListSanPham.aspx.cs" Inherits="ShopNhaViet.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
         <div>
         <hgroup>
         <h2><%: Page.Title %></h2>
         </hgroup>
         <asp:ListView ID="ListSanPham" runat="server" DataKeyNames="SanPhamID"
        GroupItemCount="4"
         ItemType="ShopNhaViet.Models.SanPham" SelectMethod="GetSanPhams">
         <EmptyDataTemplate>
         <table >
         <tr>
         <td>No data was returned.</td>
         </tr>
         </table>
         </EmptyDataTemplate>
         <EmptyItemTemplate>
         <td/>
         </EmptyItemTemplate>
         <GroupTemplate>
         <tr id="itemPlaceholderContainer" runat="server">
         <td id="itemPlaceholder" runat="server"></td>
         </tr>
         </GroupTemplate>
         <ItemTemplate>
         <td runat="server">
         <table>
         <tr>
         <td>
         <a href="chitietsanpham.aspx?SanPhamID=<%#:Item.SanPhamID%>">
         <img src ="/Images/<%#:Item.HinhAnh%>"
         width="150" height="225" style="border:solid" /></a>
         </td>
         </tr>
         <tr>
         <%--<td>
         <a href="chitietsanpham.aspx?SanPhamID=<%#:Item.SanPhamID%>">
         <span>
         <%#:Item.TenSanPham%>
         </span>
         </a>
         <br />
         <span>
         <b>Price: </b><%#:String.Format("{0:c}",Item.MoTa)%>
         </span>
         <br />
             <a href="AddToCart.aspx?bookID=<%#:Item.SanPhamID%>">
             <span>
             <b>Add To Cart<b>
             </span>
             </a>
         </td>--%>
         </tr>
         <tr>
         <td>&nbsp;</td>
         </tr>
         </table>
         </p>
         </td>
         </ItemTemplate>
         <LayoutTemplate>
         <table style="width:100%;">
         <tbody>
         <tr>
         <td>
         <table id="groupPlaceholderContainer" runat="server"
        style="width:100%">
         <tr id="groupPlaceholder"></tr>
         </table>
         </td>
         </tr>
         <tr>
         <td></td>
         </tr>
         <tr></tr>
         </tbody>
         </table>
         </LayoutTemplate>
         </asp:ListView>
         </div>
         </section>
</asp:Content>
