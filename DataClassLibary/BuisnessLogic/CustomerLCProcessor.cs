using DataClassLibary.DataAccess;
using DataClassLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassLibary.BuisnessLogic
{
    public static class CustomerLCProcessor
    {// this class is for processing all of the SQL commands. 
        //create customer is a method that will add data to the database 
        public static int CreateCustomer(int customerID, string firstName, string lastName, string email,
          string employeed, string buynowpaylater)
        {
            CustomerLoyaltyCardModel data = new CustomerLoyaltyCardModel
            {
                CustomerID = customerID,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Employeed = employeed,
                BuyNowPayLater = buynowpaylater
              
            };

            string sql = @"insert into DE-StoreData.BuyNowPaylater (CustomerID, FirstName, LastName, Email, Employeed,
                            BuyNowPayLater) Values @CustomerID, @FirstName, @LastName, @Email, @Employeed,
                            @BuyNowPayLater);";


            return DE_StoreDA.SaveData(sql, data);
        }
        // LoadCardModel is a method that will load data from the database 
        public static List<CustomerLoyaltyCardModel> LoadcardModels()
        {
            string sql = @"select CustomerID, FirstName, LastName, Email, Employeed,
                            BuyNowPayLater from DE-StoreData.BuyNowPaylater;";

            return DE_StoreDA.LoadData<CustomerLoyaltyCardModel>(sql);

        }
    }
}

