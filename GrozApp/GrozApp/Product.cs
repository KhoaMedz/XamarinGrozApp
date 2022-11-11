using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace GrozApp
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int maSanPham { get; set; }
        public int maLoai { get; set; }
        public string tenSanPham { get; set; }
        public long giaSanPham { get; set; }
        public string hinhSanPham { get; set; }
        public string moTaSanPham { get; set; }

    }
}
