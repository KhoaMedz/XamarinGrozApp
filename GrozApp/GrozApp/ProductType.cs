using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GrozApp
{
    public class ProductType
    {
        [PrimaryKey, AutoIncrement]
        public int maLoai { get; set; }
        public string tenLoai { get; set; }
        public string hinhThuNhat { get; set; }
        public string hinhThuHai { get; set; }
        public string hinhThuBa { get; set; }

    }
}
