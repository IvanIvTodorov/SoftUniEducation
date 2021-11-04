using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        private List<Stock> portfolio;

        public Investor(string fullName, string email, decimal money, string brokerName)
        {
            FullName = fullName;
            EmailAddress = email;
            MoneyToInvest = money;
            BrokerName = brokerName;
            portfolio = new List<Stock>();
        }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public int Count { get => portfolio.Count; }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000)
            {
                if (MoneyToInvest >= stock.PricePerShare)
                {
                    if (portfolio.Any(n => n.CompanyName == stock.CompanyName))
                    {
                        int index = portfolio.FindIndex(n => n.CompanyName == stock.CompanyName);
                        portfolio[index] = stock;
                    }
                    else
                    {
                        portfolio.Add(stock);
                        MoneyToInvest -= stock.PricePerShare;
                    }
                    
                }
            }
        }

        public string SellStock(string company, decimal price)
        {

            if (portfolio.Any(n => n.CompanyName == company) == false)
            {
                return  $"{company} does not exist.";
            }
            else
            {
                Stock stock = portfolio.First(n => n.CompanyName == company);
                if (price < stock.PricePerShare)
                {
                    return  $"Cannot sell {company}.";
                }
                else
                {                    
                    portfolio.Remove(stock);
                    MoneyToInvest += price;
                    return $"{company} was sold.";
                }
            }
        }

        public Stock FindStock(string company)
        {
            Stock stock = null;

            if (portfolio.Any(n => n.CompanyName == company))
            {
                stock = portfolio.First(n => n.CompanyName == company);
            }

            return stock;
        }


        public Stock FindBiggestCompany()
        {
            Stock stock = null;

            if (portfolio.Any())
            {
                stock = portfolio.OrderByDescending(n => n.MarketCapitalization).First();
            }
            return stock;
        }


        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var stock in portfolio)
            {
                sb.AppendLine(stock.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
