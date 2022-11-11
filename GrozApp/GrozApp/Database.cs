using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GrozApp
{
    public class Database
    {
        string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool createDatabase()
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                connection.CreateTable<ProductType>();
                connection.CreateTable<Product>();
                connection.CreateTable<CartItem>();
                connection.CreateTable<User>();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool createProductTypeData()
        {
            List<ProductType> productTypesList = new List<ProductType>();

            productTypesList.Add(new ProductType
            {
                maLoai = 1,
                tenLoai = "Áo",
                hinhThuNhat = "tshirt.png",
                hinhThuHai = "tshirt2.png",
                hinhThuBa = "tshirt3.png"
            });
            productTypesList.Add(new ProductType
            {
                maLoai = 2,
                tenLoai = "Quần",
                hinhThuNhat = "pants1.png",
                hinhThuHai = "pants2.png",
                hinhThuBa = "pants3.png"
            });
            productTypesList.Add(new ProductType
            {
                maLoai = 3,
                tenLoai = "Giày",
                hinhThuNhat = "shoes1.png",
                hinhThuHai = "shoes2.png",
                hinhThuBa = "shoes3.png"
            });
            productTypesList.Add(new ProductType
            {
                maLoai = 4,
                tenLoai = "Nón",
                hinhThuNhat = "hat1.png",
                hinhThuHai = "hat2.png",
                hinhThuBa = "hat3.png"
            });
            productTypesList.Add(new ProductType
            {
                maLoai = 5,
                tenLoai = "Phụ Kiện Khác",
                hinhThuNhat = "accessories1.png",
                hinhThuHai = "accessories2.png",
                hinhThuBa = "accessories3.png"
            });
            productTypesList.Add(new ProductType
            {
                maLoai = 6,
                tenLoai = "Dép",
                hinhThuNhat = "sandal1.png",
                hinhThuHai = "sandal2.png",
                hinhThuBa = "sandal3.png"
            });
            productTypesList.Add(new ProductType
            {
                maLoai = 7,
                tenLoai = "Ô Dù",
                hinhThuNhat = "umbrella1.png",
                hinhThuHai = "umbrella2.png",
                hinhThuBa = "umbrella3.png"
            });

            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));

                if(connection.Table<ProductType>().Count() == 0)
                {
                    foreach (ProductType productType in productTypesList)
                        connection.Insert(productType);
                }

                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool createProductData()
        {
            List<Product> listProduct = new List<Product>();

            //Áo
            listProduct.Add(new Product
            {
                maSanPham = 1,
                maLoai = 1,
                giaSanPham = 100,
                hinhSanPham = "ao1.jpg",
                moTaSanPham = "Đã Bán: 5",
                tenSanPham = "Áo 01"
            });

            listProduct.Add(new Product
            {
                maSanPham = 2,
                maLoai = 1,
                giaSanPham = 36,
                hinhSanPham = "ao2.jpg",
                moTaSanPham = "Đã Bán: 52",
                tenSanPham = "Áo 02"
            });

            listProduct.Add(new Product
            {
                maSanPham = 3,
                maLoai = 1,
                giaSanPham = 57,
                hinhSanPham = "ao3.jpg",
                moTaSanPham = "Đã Bán: 67",
                tenSanPham = "Áo 03"
            });

            listProduct.Add(new Product
            {
                maSanPham = 4,
                maLoai = 1,
                giaSanPham = 99,
                hinhSanPham = "ao4.jpg",
                moTaSanPham = "Đã Bán: 14",
                tenSanPham = "Áo 04"
            });

            listProduct.Add(new Product
            {
                maSanPham = 5,
                maLoai = 1,
                giaSanPham = 235,
                hinhSanPham = "ao5.jpg",
                moTaSanPham = "Đã Bán: 29",
                tenSanPham = "Áo 05"
            });

            listProduct.Add(new Product
            {
                maSanPham = 6,
                maLoai = 1,
                giaSanPham = 75,
                hinhSanPham = "ao6.jpg",
                moTaSanPham = "Đã Bán: 38",
                tenSanPham = "Áo 06"
            });

            //Quần
            listProduct.Add(new Product
            {
                maSanPham = 7,
                maLoai = 2,
                giaSanPham = 45,
                hinhSanPham = "quan1.jpg",
                moTaSanPham = "Đã Bán: 02",
                tenSanPham = "Quần 01"
            });

            listProduct.Add(new Product
            {
                maSanPham = 8,
                maLoai = 2,
                giaSanPham = 50,
                hinhSanPham = "quan2.jpg",
                moTaSanPham = "Đã Bán: 05",
                tenSanPham = "Quần 02"
            });

            listProduct.Add(new Product
            {
                maSanPham = 9,
                maLoai = 2,
                giaSanPham = 450,
                hinhSanPham = "quan3.jpg",
                moTaSanPham = "Đã Bán: 12",
                tenSanPham = "Quần 03"
            });

            listProduct.Add(new Product
            {
                maSanPham = 10,
                maLoai = 2,
                giaSanPham = 40,
                hinhSanPham = "quan4.jpg",
                moTaSanPham = "Đã Bán: 22",
                tenSanPham = "Quần 04"
            });

            listProduct.Add(new Product
            {
                maSanPham = 11,
                maLoai = 2,
                giaSanPham = 65,
                hinhSanPham = "quan5.jpg",
                moTaSanPham = "Đã Bán: 72",
                tenSanPham = "Quần 05"
            });

            listProduct.Add(new Product
            {
                maSanPham = 12,
                maLoai = 2,
                giaSanPham = 96,
                hinhSanPham = "quan6.jpg",
                moTaSanPham = "Đã Bán: 32",
                tenSanPham = "Quần 06"
            });

            listProduct.Add(new Product
            {
                maSanPham = 13,
                maLoai = 2,
                giaSanPham = 76,
                hinhSanPham = "quan7.jpg",
                moTaSanPham = "Đã Bán: 45",
                tenSanPham = "Quần 07"
            });

            listProduct.Add(new Product
            {
                maSanPham = 14,
                maLoai = 2,
                giaSanPham = 42,
                hinhSanPham = "quan8.jpg",
                moTaSanPham = "Đã Bán: 23",
                tenSanPham = "Quần 08"
            });

            //Giày
            listProduct.Add(new Product
            {
                maSanPham = 15,
                maLoai = 3,
                giaSanPham = 100,
                hinhSanPham = "giay1.jpg",
                moTaSanPham = "Đã Bán: 03",
                tenSanPham = "Giày 01"
            });

            listProduct.Add(new Product
            {
                maSanPham = 16,
                maLoai = 3,
                giaSanPham = 125,
                hinhSanPham = "giay2.jpg",
                moTaSanPham = "Đã Bán: 33",
                tenSanPham = "Giày 02"
            });

            listProduct.Add(new Product
            {
                maSanPham = 17,
                maLoai = 3,
                giaSanPham = 130,
                hinhSanPham = "giay3.jpg",
                moTaSanPham = "Đã Bán: 45",
                tenSanPham = "Giày 03"
            });

            listProduct.Add(new Product
            {
                maSanPham = 18,
                maLoai = 3,
                giaSanPham = 250,
                hinhSanPham = "giay4.jpg",
                moTaSanPham = "Đã Bán: 74",
                tenSanPham = "Giày 04"
            });

            listProduct.Add(new Product
            {
                maSanPham = 19,
                maLoai = 3,
                giaSanPham = 380,
                hinhSanPham = "giay5.jpg",
                moTaSanPham = "Đã Bán: 09",
                tenSanPham = "Giày 05"
            });

            //Nón
            listProduct.Add(new Product
            {
                maSanPham = 20,
                maLoai = 4,
                giaSanPham = 75,
                hinhSanPham = "non1.jpg",
                moTaSanPham = "Đã Bán: 29",
                tenSanPham = "Nón 01"
            });

            listProduct.Add(new Product
            {
                maSanPham = 21,
                maLoai = 4,
                giaSanPham = 10,
                hinhSanPham = "non2.jpg",
                moTaSanPham = "Đã Bán: 79",
                tenSanPham = "Nón 02"
            });

            listProduct.Add(new Product
            {
                maSanPham = 22,
                maLoai = 4,
                giaSanPham = 99,
                hinhSanPham = "non3.jpg",
                moTaSanPham = "Đã Bán: 64",
                tenSanPham = "Nón 03"
            });

            listProduct.Add(new Product
            {
                maSanPham = 23,
                maLoai = 4,
                giaSanPham = 62,
                hinhSanPham = "non4.jpg",
                moTaSanPham = "Đã Bán: 93",
                tenSanPham = "Nón 04"
            });

            listProduct.Add(new Product
            {
                maSanPham = 24,
                maLoai = 4,
                giaSanPham = 59,
                hinhSanPham = "non5.jpg",
                moTaSanPham = "Đã Bán: 04",
                tenSanPham = "Nón 05"
            });

            //Phụ kiện khác
            listProduct.Add(new Product
            {
                maSanPham = 25,
                maLoai = 5,
                giaSanPham = 32,
                hinhSanPham = "phukien1.jpg",
                moTaSanPham = "Đã Bán: 01",
                tenSanPham = "Phụ Kiện 01"
            });

            listProduct.Add(new Product
            {
                maSanPham = 26,
                maLoai = 5,
                giaSanPham = 36,
                hinhSanPham = "phukien2.jpg",
                moTaSanPham = "Đã Bán: 00",
                tenSanPham = "Phụ Kiện 02"
            });

            listProduct.Add(new Product
            {
                maSanPham = 27,
                maLoai = 5,
                giaSanPham = 96,
                hinhSanPham = "phukien3.jpg",
                moTaSanPham = "Đã Bán: 95",
                tenSanPham = "Phụ Kiện 03"
            });

            listProduct.Add(new Product
            {
                maSanPham = 28,
                maLoai = 5,
                giaSanPham = 46,
                hinhSanPham = "phukien4.jpg",
                moTaSanPham = "Đã Bán: 43",
                tenSanPham = "Phụ Kiện 04"
            });

            //Dép
            listProduct.Add(new Product
            {
                maSanPham = 29,
                maLoai = 6,
                giaSanPham = 56,
                hinhSanPham = "dep1.jpg",
                moTaSanPham = "Đã Bán: 12",
                tenSanPham = "Dép 01"
            });

            listProduct.Add(new Product
            {
                maSanPham = 30,
                maLoai = 6,
                giaSanPham = 23,
                hinhSanPham = "dep2.jpg",
                moTaSanPham = "Đã Bán: 11",
                tenSanPham = "Dép 02"
            });

            listProduct.Add(new Product
            {
                maSanPham = 31,
                maLoai = 6,
                giaSanPham = 66,
                hinhSanPham = "dep3.jpg",
                moTaSanPham = "Đã Bán: 03",
                tenSanPham = "Dép 03"
            });

            listProduct.Add(new Product
            {
                maSanPham = 32,
                maLoai = 6,
                giaSanPham = 20,
                hinhSanPham = "dep4.jpg",
                moTaSanPham = "Đã Bán: 91",
                tenSanPham = "Dép 04"
            });

            listProduct.Add(new Product
            {
                maSanPham = 33,
                maLoai = 6,
                giaSanPham = 36,
                hinhSanPham = "dep5.jpg",
                moTaSanPham = "Đã Bán: 22",
                tenSanPham = "Dép 05"
            });

            listProduct.Add(new Product
            {
                maSanPham = 34,
                maLoai = 6,
                giaSanPham = 63,
                hinhSanPham = "dep6.jpg",
                moTaSanPham = "Đã Bán: 42",
                tenSanPham = "Dép 06"
            });

            //Ô dù
            listProduct.Add(new Product
            {
                maSanPham = 35,
                maLoai = 7,
                giaSanPham = 25,
                hinhSanPham = "du1.jpg",
                moTaSanPham = "Đã Bán: 01",
                tenSanPham = "Dù 01"
            });

            listProduct.Add(new Product
            {
                maSanPham = 36,
                maLoai = 7,
                giaSanPham = 50,
                hinhSanPham = "du2.jpg",
                moTaSanPham = "Đã Bán: 31",
                tenSanPham = "Dù 02"
            });

            listProduct.Add(new Product
            {
                maSanPham = 37,
                maLoai = 7,
                giaSanPham = 55,
                hinhSanPham = "du3.jpg",
                moTaSanPham = "Đã Bán: 95",
                tenSanPham = "Dù 03"
            });

            listProduct.Add(new Product
            {
                maSanPham = 38,
                maLoai = 7,
                giaSanPham = 25,
                hinhSanPham = "du4.jpg",
                moTaSanPham = "Đã Bán: 45",
                tenSanPham = "Dù 04"
            });

            listProduct.Add(new Product
            {
                maSanPham = 39,
                maLoai = 7,
                giaSanPham = 47,
                hinhSanPham = "du5.jpg",
                moTaSanPham = "Đã Bán: 38",
                tenSanPham = "Dù 05"
            });

            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));

                if(connection.Table<Product>().Count() == 0)
                    foreach (Product product in listProduct)
                        connection.Insert(product);
    
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertProduct(Product product)
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                connection.Insert(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertCartItem(CartItem cartItem)
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                connection.Insert(cartItem);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool insertUser(User user)
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                connection.Insert(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Product> selectAllProduct()
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                return connection.Table<Product>().ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<ProductType> selectAllProductType()
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                return connection.Table<ProductType>().ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<Product> selectProductByType(int maLoai)
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                return connection.Query<Product>("SELECT * FROM Product WHERE maLoai = " + maLoai.ToString());
            }
            catch
            {
                return null;
            }
        }
        public List<CartItem> selectAllCartItem()
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                return connection.Table<CartItem>().ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<User> selectAllUser()
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                return connection.Table<User>().ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool deleteProduct(Product product)
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                connection.Delete(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCartItem(CartItem cartItem)
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                connection.Delete(cartItem);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool clearAllProductTypeData()
        {
            try
            {
                var connection = new SQLiteConnection(System.IO.Path.Combine(path, "GrozDatabase.db"));
                connection.Query<ProductType>("DELETE FROM ProductType");
                connection.Query<ProductType>("DELETE FROM sqlite_sequence WHERE name = 'ProductType'"); // reset the auto increasement ID index
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
