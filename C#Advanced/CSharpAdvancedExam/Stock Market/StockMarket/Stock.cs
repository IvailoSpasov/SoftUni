namespace StockMarket
{
    public class Stock
    {
        public Stock(string companyName,string director,decimal pricePerShare,int totalNumberOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumberOfShares;
            MarketCapitalization = totalNumberOfShares * pricePerShare;
        }

        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization { get; set; }

        public override string ToString()
        {
            return
                $"Company: {CompanyName}\nDirector: {Director}\nPrice per share: ${PricePerShare}\nMarket capitalization: ${MarketCapitalization}";

        }
    }
}
