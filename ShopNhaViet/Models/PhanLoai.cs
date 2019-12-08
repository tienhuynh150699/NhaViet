using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopNhaViet.Models
{
    public class PhanLoai
    {
        [ScaffoldColumn(false)]
        public int PhanLoaiID { get; set; }
        [Required, StringLength(100), Display(Name = "Ten")]
        public string TenLoai { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}