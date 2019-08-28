using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Quartz;
using WebApiMvc.Data.API;
using WebApiMvc.Data.API.Work;
using WebApiMvc.Dtos.Markets.Binance;

namespace WebApiMvc.Data.Quartz
{
    [DisallowConcurrentExecution]    
    public class BotApiJob: IJob
    {
        private readonly ILogger<BotApiJob> _logger;
        public BotApiJob(ILogger<BotApiJob> logger)
        {
            _logger = logger;
        }

        public async Task Execute(IJobExecutionContext context) {
            //var get24hrTicker = new GetDataFromApi<_24hrTickerDto>();
            var get24hrTicker = new GetDataFromApi<OrderBook>();

            var BNBBTC_orderBook = await get24hrTicker.GetDataAsync(ApiUrl.orderBook, "BNBBTC");
            //var BNBBTC_24hrTicker = await get24hrTicker.GetDataAsync(ApiUrl.Binance24hr, "BTC");
            
            _logger.LogInformation("Торги BNBBTC");
            _logger.LogInformation(BNBBTC_orderBook.ToString());
            //_logger.LogInformation(BNBBTC_24hrTicker.ToString());
            // return Task.CompletedTask;
        }
    }
}