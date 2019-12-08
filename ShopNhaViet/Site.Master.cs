
using ShopNhaViet.Logic;
using ShopNhaViet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopNhaViet
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<PhanLoai> GetCategories()
        {
            var _db = new ShopNhaViet.Models.LienKet();
            IQueryable<PhanLoai> query = _db.PhanLoais;
            return query;
        }        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (ShoppingCartActions usersShoppingCart = new
            ShoppingCartActions())
            {
                string cartStr = string.Format("Giỏ Hàng ({0})",
                usersShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }
    }
}