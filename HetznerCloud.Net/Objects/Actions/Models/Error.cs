﻿using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Actions.Models
{
    public class Error
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}