using ShopNhaViet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopNhaViet
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<SanPham> GetSanPhams([QueryString("SanPhamID")] int? SanPhamid)
        {
            var _db = new ShopNhaViet.Models.LienKet();
            IQueryable<SanPham> query = _db.SanPhams;
            if (SanPhamid.HasValue && SanPhamid > 0)
            {
                query = query.Where(p => p.SanPhamID == SanPhamid);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}