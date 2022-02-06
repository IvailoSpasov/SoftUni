using System.Collections.Generic;
using System.Linq;

namespace StockMarket
{
    public class Investor
    {


        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            Portfolio = new Dictionary<string, Stock>();
        }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public Dictionary<string, Stock> Portfolio { get; set; }

        public int Count
        {
            get { return Portfolio.Count; }

        }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && MoneyToInvest >= stock.PricePerShare)
            {
                Portfolio.Add(stock.CompanyName, stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            if (Portfolio.ContainsKey(companyName))
            {
                if (sellPrice < Portfolio[companyName].PricePerShare)
                {
                    return $"Cannot sell {companyName}.";

                }
                else
                {
                    MoneyToInvest += sellPrice;
                    Portfolio.Remove(companyName);
                    return $"{companyName} was sold.";
                }
            }
            else
            {
                return $"{companyName} does not exist.";
            }
        }

        public Stock FindStock(string companyName)
        {
            if (Portfolio.ContainsKey(companyName))
            {
                return Portfolio[companyName];
            }
            else
            {
                return null;
            }
        }

        public Stock FindBiggestCompany()
        {
            if (Portfolio.Count > 0)
            {
                foreach (var stock in Portfolio.OrderByDescending(x => x.Value.MarketCapitalization).Take(1))
                {
                    return stock.Value;
                }
            }

            return null;
        }

        public string InvestorInformation()
        {
            return
                $"The investor {FullName} with a broker {BrokerName} has stocks:\n{string.Join("\n", Portfolio.Values)}";

        }
    }
}
