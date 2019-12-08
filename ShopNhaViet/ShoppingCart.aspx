<%@ Page Title="Giỏ Hàng" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="ShopNhaViet.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ShoppingCartTitle" runat="server" class="ContentHead"><h1>Giỏ Hàng</h1></div>
     <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False"
     ShowFooter="True" GridLines="Vertical" CellPadding="4"
     ItemType="ShopNhaViet.Models.CartItem"
     SelectMethod ="GetShoppingCartItems"
     CssClass="table table-striped table-bordered" >
     <Columns><asp:BoundField DataField="SanPhamID" HeaderText="ID"
     SortExpression="SanPhamID" />
     <asp:BoundField DataField="SanPham.TenSanPham" HeaderText="Tên Sản Phẩm" />
     <asp:BoundField DataField="SanPham.GiaTien" HeaderText="Giá Tiền"
     DataFormatString="{0:c}"/>
     <asp:TemplateField HeaderText="Số Lượng">
     <ItemTemplate>
     <asp:TextBox ID="PurchaseQuantity" Width="40"
     runat="server" Text="<%#: Item.Quantity %>"></asp:TextBox>
     </ItemTemplate>
     </asp:TemplateField>
     <asp:TemplateField HeaderText="Tổng">
     <ItemTemplate>
     <%#: String.Format("{0:c}",
     ((Convert.ToDouble(Item.Quantity)) *
    Convert.ToDouble(Item.SanPham.GiaTien)))%>
     </ItemTemplate>
     </asp:TemplateField>
     <asp:TemplateField HeaderText="Xóa Chọn">
     <ItemTemplate>
     <asp:CheckBox id="Remove" runat="server"></asp:CheckBox>
     </ItemTemplate>
     </asp:TemplateField>
     </Columns>
    </asp:GridView>
    <div>
     <p></p>
     <strong>
     <asp:Label ID="LabelTotalText" runat="server" Text="Tổng Cộng:"></asp:Label>
     <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
     </strong>
    </div>
    <br />
    <table>
    <tr>
    <td>
    <asp:Button ID="UpdateBtn" runat="server" Text="Làm Mới"
    OnClick="UpdateBtn_Click" />
    </td>
    </tr>
    </table>
</asp:Content>
