using Newtonsoft.Json;

namespace Pango.Application.AzureCliData;

public class AzureCliLoginInformation
{
    [JsonProperty("environmentName")]
    public string EnvironmentName { get; set; } = null!;

    [JsonProperty("homeTenantId")]
    public string HomeTenantId { get; set; } = null!;

    [JsonProperty("id")]
    public string Id { get; set; } = null!;

    [JsonProperty("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; } = null!;

    [JsonProperty("state")]
    public string State { get; set; } = null!;

    [JsonProperty("tenantId")]
    public string TenantId { get; set; } = null!;

    [JsonProperty("user")]
    public AzureCliUser User { get; set; } = null!;
}
