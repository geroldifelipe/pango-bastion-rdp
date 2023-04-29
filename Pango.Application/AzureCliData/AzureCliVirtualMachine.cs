using Newtonsoft.Json;

namespace Pango.Application.AzureCliData;

public class AzureCliVirtualMachine
{
    [JsonProperty("id")]
    public string Id { get; set; } = null!;

    [JsonProperty("name")]
    public string Name { get; set; } = null!;

    [JsonProperty("resourceGroup")]
    public string ResourceGroup { get; set; } = null!;
}
