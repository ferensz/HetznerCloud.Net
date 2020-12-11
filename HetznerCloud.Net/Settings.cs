using System.Text.Json;

namespace HetznerCloud.Net
{
    public class Settings
    {
        /// <summary>
        /// Default JSON serializer options which enables the serialization of lowercase JSON string into
        /// CamelCase object properties
        /// </summary>
        internal static JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions()
        {
            AllowTrailingCommas = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
    }
}