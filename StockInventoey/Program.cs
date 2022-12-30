using System;

namespace StockInventoey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockAccountManagement stockAccountManagement = new StockAccountManagement();

            string stockFilePath = @"E:\RFP 232 BATCH\JSON_PRACTICE_PROBLEMS\StockInventoey\Stock.json";
            stockAccountManagement.ReadStockJsonFile(stockFilePath);
            string customerFilePath = @"E:\RFP 232 BATCH\JSON_PRACTICE_PROBLEMS\StockInventoey\Stock.json";
            stockAccountManagement.ReadCustomerJsonFile(customerFilePath);
            stockAccountManagement.BuyStock("Google");
            stockAccountManagement.SellStocks("Amazon");
            stockAccountManagement.WriteToStockJsonFile(stockFilePath);
            stockAccountManagement.WriteToStockJsonFile(customerFilePath);

        }
    }
}
