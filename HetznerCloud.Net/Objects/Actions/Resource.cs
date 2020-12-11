﻿using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Actions
{
    public class Resource
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}