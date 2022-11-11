using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GrozApp
{
    public class CartItem
    {
        [PrimaryKey, AutoIncrement]
        public int maItem { get; set; }
        public string hinhSanPham { get; set; }
        public string tenSanPham { get; set; }
        public long giaSanPham { get; set; }
        public int soLuong { get; set; }
        public long tongGiaSanPham { get; set; } // tongGiaSanPham = giaSanPham * soLuong
    }
}
