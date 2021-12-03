using DataClassLibary.DataAccess;
using DataClassLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassLibary.BuisnessLogic
{
    public static class SaleProcessor
    {
        public static int CreateSale(int saleid, string saletype)
        {
            SaleModel sale = new SaleModel
            {
                SaleID = saleid, 
                SaleType = saletype
            };

            string sql = @"insert into DE-StoreData.Sales 
                        (saleid, saletype) values @SaleID, @SaleType);";


            return DE_StoreDA.SaveData(sql, sale);

        }

        public static List<SaleModel> GetSales()
        {
            string sql = @" select SaleID, Saletype from DE-StoreData.Sales;";

            return DE_StoreDA.LoadData<SaleModel>(sql);
        }
    }
}
