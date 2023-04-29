using Newtonsoft.Json;

namespace Pango.Application.AzureCliData;

public class AzureCliUser
{
    [JsonProperty("name")]
    public string Name { get; set; } = null!;

    [JsonProperty("type")]
    public string Type { get; set; } = null!;
}
