using Prism.Mvvm;
using System;

namespace EbestTradeBot.Client
{
    public class DefaultOptions : BindableBase
    {
        private decimal _secondTradePrice = 0m;
        public decimal SecondTradePrice
        {
            get => _secondTradePrice;
            set => SetProperty(ref _secondTradePrice, value);
        }
        private decimal _firstTradePrice = 0m;
        public decimal FirstTradePrice
        {
            get => _firstTradePrice;
            set => SetProperty(ref _firstTradePrice, value);
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

        public DateTime _startTime = DateTime.MinValue;
        public DateTime StartTime
        {
            get => _startTime;
            set => SetProperty(ref _startTime, value);
        }

        public DateTime _endTime = DateTime.MinValue;
        public DateTime EndTime
        {
            get => _endTime;
            set => SetProperty(ref _endTime, value);
        }
    }
}
