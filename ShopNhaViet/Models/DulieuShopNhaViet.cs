using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopNhaViet.Models
{
    public class DulieuShopNhaViet : DropCreateDatabaseAlways<LienKet>
    {
        protected override void Seed(LienKet context)
        {
            GetPhanLoais().ForEach(c => context.PhanLoais.Add(c));
            GetSanPhams().ForEach(p => context.SanPhams.Add(p));
        }
        private static List<PhanLoai> GetPhanLoais()
        {
            var phanloais = new List<PhanLoai>
            {
                new PhanLoai
                {
                    PhanLoaiID = 1,
                    TenLoai = "bàn ăn"
                },
                new PhanLoai
                {
                    PhanLoaiID = 2,
                    TenLoai = "Ghế"
                }
            };
            return phanloais;
        }
        private static List<SanPham> GetSanPhams()
        {
            var sanphams = new List<SanPham> {
                new SanPham
                {
                    SanPhamID = 1,
                    TenSanPham = "Bàn trà",
                    MoTa = "Phong cách hiện đại",
                    HinhAnh ="bantra.jpg",
                    GiaTien = 200000,
                    PhanLoaiID = 1
                    },
                new SanPham
                {
                    SanPhamID = 2,
                    TenSanPham = "Bàn ăn",
                    MoTa = "Phong cách đơn giản",
                    HinhAnh ="banan1.jpg",
                    GiaTien = 150000,
                    PhanLoaiID = 1
                },
                new SanPham
                {
                    SanPhamID = 3,
                    TenSanPham = "Ghế",
                    MoTa = " Phong cách Châu Âu",
                    HinhAnh ="ghe.jpg",
                    GiaTien = 168000,
                    PhanLoaiID = 2
                },
                new SanPham
                {
                    SanPhamID = 4,
                    TenSanPham = "Salong",
                    MoTa = "Salong hiện đại kiểu bắc mỹ",
                    HinhAnh ="salong.jpg",
                    GiaTien = 210000,
                    PhanLoaiID = 2
                },
            };
            return sanphams;
        }
    }
}