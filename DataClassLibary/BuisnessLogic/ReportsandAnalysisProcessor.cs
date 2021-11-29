using DataClassLibary.DataAccess;
using DataClassLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassLibary.BuisnessLogic
{
    public static class ReportsandAnalysisProcessor
    {
        public static int CreateReports(int ReportID, string ShopName, string ShopLocation, int ItemsSold, int CustomerFootFall, DateTime date )
        {
            ReportsAnalysisModel data = new ReportsAnalysisModel
            {
                 ReportID = ReportID,
                 ShopName = ShopName,
                 ShopLocation = ShopLocation,
                 ItemsSold = ItemsSold,
                 CustomerFootFall = CustomerFootFall,
                 Date = date
            };

            string sql = @"insert into DE-StoreData.ReportsAndAnalysis (ReportID, ShopName, ShopLocation, ItemsSold, CustomerFootFall,
                               Date) values @ReportID, @ShopName, @ShopLocation, @ItemsSold, @CustomerFootFall, @Date);";  

            return DE_StoreDA.SaveData(sql, data);
        }

    }
}
