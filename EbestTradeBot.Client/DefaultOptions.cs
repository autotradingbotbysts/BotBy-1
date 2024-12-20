using Prism.Mvvm;

namespace EbestTradeBot.Client
{
    public class DefaultOptions : BindableBase
    {
        private decimal _tradePrice = 0m;
        public decimal TradePrice
        {
            get => _tradePrice;
            set => SetProperty(ref _tradePrice, value);
        }

        private bool _isTestTrade = true;
        public bool IsTestTrade
        {
            get => _isTestTrade;
            set => SetProperty(ref _isTestTrade, value);
        }

        private int _replySecond = 0;
        public int ReplySecond
        {
            get => _replySecond;
            set => SetProperty(ref _replySecond, value);
        }
    }
}
