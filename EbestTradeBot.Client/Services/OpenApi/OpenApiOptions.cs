﻿using Prism.Mvvm;

namespace EbestTradeBot.Client.Services.OpenApi
{
    public class OpenApiOptions : BindableBase
    {
        private string _appKey = string.Empty;
        public string AppKey
        {
            get => _appKey;
            set => SetProperty(ref _appKey, value);
        }

        private string _secretKey = string.Empty;
        public string SecretKey
        {
            get => _secretKey;
            set => SetProperty(ref _secretKey, value);
        }
    }
}
