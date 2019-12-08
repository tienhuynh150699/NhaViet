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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<SanPham> GetSanPhams([QueryString("id")] int? PhanLoaiId)
        {
            var _db = new ShopNhaViet.Models.LienKet();
            IQueryable<SanPham> query = _db.SanPhams;
            if (PhanLoaiId.HasValue && PhanLoaiId > 0)
            {
                query = query.Where(p => p.PhanLoaiID == PhanLoaiId);
            }
            return query;
        }
    }
}