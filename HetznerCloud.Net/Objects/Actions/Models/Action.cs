using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Actions.Models
{
    public class Action
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("command")]
        public string Command { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public long Progress { get; set; }

        [JsonPropertyName("started")]
        public DateTimeOffset Started { get; set; }

        [JsonPropertyName("finished")]
        public DateTimeOffset Finished { get; set; }

        [JsonPropertyName("resources")]
        public List<Resource> Resources { get; set; }

        [JsonPropertyName("error")]
        public Error Error { get; set; }
    }
}