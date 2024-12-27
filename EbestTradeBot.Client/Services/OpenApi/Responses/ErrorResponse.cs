using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EbestTradeBot.Client.Services.OpenApi.Responses
{
    public class ErrorResponse
    {
        [JsonPropertyName("rsp_cd")]
        public string RspCd { get; set; } = string.Empty;
        [JsonPropertyName("rsp_msg")]
        public string RspMsg { get; set; } = string.Empty;
    }
}
