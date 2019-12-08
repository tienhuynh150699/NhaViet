using System.Data.Entity;

namespace ShopNhaViet.Models
{
    public class LienKet : DbContext
    {
        public LienKet() : base("BooksShopOnline")
        { }
        public DbSet<PhanLoai> PhanLoais { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }        //public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}