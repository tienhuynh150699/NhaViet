using ShopNhaViet.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopNhaViet
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["SanPhamId"];
            int SanPhamID;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out SanPhamID))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a SanPhamID.");

                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a SanPhamID.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}