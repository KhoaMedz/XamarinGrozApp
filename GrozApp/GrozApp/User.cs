using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GrozApp
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int userID { get; set; }
        public string hoTen { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public string matKhau { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
    }
}
