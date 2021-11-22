using DataLibary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DataLibary.DataAccess;

namespace DataLibary.BusinessLogic
{
    public class CustomerLoyaltyCardProcessor
    {
        public static int CreateCustomer(int customerID, string firstName, string lastName, string email,
            bool employeed, bool buynowpaylater)
        {
            CustomerLoyaltyCardModel data = new CustomerLoyaltyCardModel
            {
                CustomerId =  customerID, 
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Employeed = employeed,
                BuyNowPayLater = buynowpaylater
            };

            string sql = @"insert into DE-StoreData.BuyNowPaylater (CustomerID, FirstName, LastName, Email, Employeed,
                            BuyNowPayLater) Values @CustomerID, @FirstName, @LastName, @Email, @Employeed,
                            @BuyNowPayLater);";


            return DE_StoreSQLDataAccess.SaveData(sql, data);
        }

        public static List<CustomerLoyaltyCardModel> LoadcardModels()
        {
            string sql = @"select CustomerID, FirstName, LastName, Email, Employeed,
                            BuyNowPayLater from DE-StoreData.BuyNowPaylater;";

            return DE_StoreSQLDataAccess.LoadData<CustomerLoyaltyCardModel>(sql);

        }
    }
}
