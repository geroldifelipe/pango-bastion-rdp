using Newtonsoft.Json;

namespace Pango.Application.AzureCliData;

public class AzureCliAccountSubscription
{
    [JsonProperty("authorizationSource")]
    public string AuthorizationSource { get; set; } = null!;

    [JsonProperty("displayName")]
    public string DisplayName { get; set; } = null!;

    [JsonProperty("id")]
    public string Id { get; set; } = null!;

    [JsonProperty("state")]
    public string State { get; set; } = null!;

    [JsonProperty("subscriptionId")]
    public string SubscriptionId { get; set; } = null!;
}
