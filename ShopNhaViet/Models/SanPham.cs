using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopNhaViet.Models
{
    public class SanPham
    {
        [ScaffoldColumn(false)]
        public int SanPhamID { get; set; }
        [Required, StringLength(100), Display(Name = "Ten")]
        public string TenSanPham { get; set; }
        [Required, StringLength(1000), Display(Name = "SanPham Description"),
        DataType(DataType.MultilineText)]
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        [Display(Name = "Gia")]
        public float? GiaTien { get; set; }
        public int? PhanLoaiID { get; set; }
        public virtual PhanLoai PhanLoai { get; set; }
    }
}