namespace WebApiMvc.Data.API
{
    public class ApiUrl
    {
        public const string baseEndpoint = "https://api.binance.com";
        public const string Binance24hr = "https://api.binance.com/api/v1/ticker/24hr?symbol=pair";
        public const string orderBook = "https://api.binance.com/api/v1/depth?symbol=pair&limit=count";
    }
}