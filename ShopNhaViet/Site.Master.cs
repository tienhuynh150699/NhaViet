﻿
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
        }
        //{
        //    using (ShoppingCartActions usersShoppingCart = new
        //    ShoppingCartActions())
        //    {
        //        string cartStr = string.Format("Cart ({0})",
        //        usersShoppingCart.GetCount());
        //        cartCount.InnerText = cartStr;
        //    }
        //}
    }
}