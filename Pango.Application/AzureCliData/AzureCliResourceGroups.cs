using Newtonsoft.Json;

namespace Pango.Application.AzureCliData;

public class AzureCliResourceGroup
{
    [JsonProperty("id")]
    public string Id { get; set; } = null!;

    [JsonProperty("name")]
    public string Name { get; set; } = null!;
}
