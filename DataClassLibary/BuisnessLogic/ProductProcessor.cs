using DataClassLibary.DataAccess;
using DataClassLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassLibary.BuisnessLogic
{
    public static class ProductProcessor
    {
        public static int AddProduct(int saleID, int productID, string productname, int price, int quantity)
        {
            ProductsModel data = new ProductsModel
            {
                SaleID = saleID,
                ProductID = productID,
                Name = productname,
                Price = price,
                Quantity = quantity
            };

            string sql = @"insert into DE-StoreData.Products (ProductID, SaleID, Name, Price, Quantity) 
                            Values @ProductID, @SaleID, @Name, @Price, @Quantity);";

            return DE_StoreDA.SaveData(sql, data);
        }

        public static List<ProductsModel> GetProducts()
        {
            string sql = @"select ProductID, SaleID, Name, Price, Quantity
                            from DE-StoreData.Products;";

            return DE_StoreDA.LoadData<ProductsModel>(sql);
        }

    }


}


