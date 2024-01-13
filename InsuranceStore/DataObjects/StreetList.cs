using System.Text.Json.Serialization;

namespace InsuranceStore.DataObjects
{
    internal class StreetList
    {
        [JsonPropertyName("help")]
        public string? Help { get; set; }
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        [JsonPropertyName("result")]
        public StreetApiResult? Result { get; set; }
    }

    public class StreetApiResult
    {
        [JsonPropertyName("include_total")]
        public bool? IncludeTotal { get; set; }
        [JsonPropertyName("limit")]
        public int? Limit { get; set; }
        [JsonPropertyName("q")]
        public string? Query { get; set; }
        [JsonPropertyName("records_format")]
        public string? RecordsFormat { get; set; }
        [JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }
        [JsonPropertyName("total_estimation_threshold")]
        public object? TotalEstimationThreshold { get; set; }
        [JsonPropertyName("records")]
        public List<StreetRecord>? Records { get; set; }
        [JsonPropertyName("fields")]
        public List<StreetField>? Fields { get; set; }
        [JsonPropertyName("_links")]
        public StreetLinks? Links { get; set; }
        [JsonPropertyName("total")]
        public int Total { get; set; }
        [JsonPropertyName("total_was_estimated")]
        public bool TotalWasEstimated { get; set; }
    }

    public class StreetRecord
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }
        [JsonPropertyName("טבלה")]
        public string? Table { get; set; }
        [JsonPropertyName("סמל_ישוב")]
        public int SettlementCode { get; set; }
        [JsonPropertyName("שם_ישוב")]
        public string? SettlementName { get; set; }
        [JsonPropertyName("סמל_רחוב")]
        public int StreetCode { get; set; }
        [JsonPropertyName("שם_רחוב")]
        public string? StreetName { get; set; }
        [JsonPropertyName("rank")]
        public float Rank { get; set; }
    }

    public class StreetField
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class StreetLinks
    {
        [JsonPropertyName("start")]
        public string? Start { get; set; }
        [JsonPropertyName("next")]
        public string? Next { get; set; }
    }
}
