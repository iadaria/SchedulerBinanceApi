namespace WebApiMvc.Dtos.Markets.Binance
{
    public class _24hrTickerDto
    {
        public string Symbol { get; set; }
        public string PriceChange { get; set; }
        public string PriceChangePercent { get; set; }
        public string WeightedAvgPrice { get; set; }
        public string PrevClosePrice { get; set; }
        public string LastPrice { get; set; }
        public string LastQty { get; set; }
        public string BidPrice { get; set; }
        public string AskPrice { get; set; }
        public string OpenPrice { get; set; }
        public string HighPrice { get; set; }
        public string LowPrice { get; set; }
        public string Volume { get; set; }
        public string QuoteVolume { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string FirstId { get; set; }
        public string LastId { get; set; }
        public string Count { get; set; }

        public override string ToString() {
            return 
                $"Пара: {Symbol}\n" +
                $"Изменение цены за последние 24 часа {PriceChange}\n" +
                $"Последняя цена: {LastPrice}\n" +
                // Аск цена предложени, цена, которую продавец заявляет как цену согласия продавать
                $"Цена продажи: {AskPrice}\n" +
                $"Цена покупки: {BidPrice}\n" +
                $"Самая высокая цена: {HighPrice}\n" +
                $"Самая низкая цена:{LowPrice}\n" +
                $"Объём: {Volume}\n" +
                $"Количество: {Count}\n";
        }

    }
}