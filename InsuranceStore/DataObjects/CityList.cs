using System.Text.Json.Serialization;

namespace InsuranceStore.DataObjects
{
    internal class CityList
    {
        public string? Help { get; set; }
        public bool Success { get; set; }
        public ApiResult? Result { get; set; }
    }

    public class ApiResult
    {
        [JsonPropertyName("include_total")]
        public bool? IncludeTotal { get; set; }
        public int Limit { get; set; }
        [JsonPropertyName("records_format")]
        public string? RecordsFormat { get; set; }
        [JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }
        [JsonPropertyName("total_estimation_threshold")]
        public object? TotalEstimationThreshold { get; set; }
        public List<Record>? Records { get; set; }
        public List<Field>? Fields { get; set; }
        public CityLinks? Links { get; set; }
        public int Total { get; set; }
        [JsonPropertyName("total_was_estimated")]
        public bool TotalWasEstimated { get; set; }
    }

    public class Record
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }
        [JsonPropertyName("טבלה")]
        public string? Table { get; set; }
        [JsonPropertyName("סמל_ישוב")]
        public int SettlementCode { get; set; }
        [JsonPropertyName("שם_ישוב")]
        public string? SettlementName { get; set; }
        [JsonPropertyName("שם_ישוב_לועזי")]
        public string? EnglishSettlementName { get; set; }
        [JsonPropertyName("סמל_נפה")]
        public int DistrictCode { get; set; }
        [JsonPropertyName("שם_נפה")]
        public string? DistrictName { get; set; }
        [JsonPropertyName("סמל_לשכת_מנא")]
        public int MunicipalityCode { get; set; }
        [JsonPropertyName("לשכה")]
        public string? MunicipalityName { get; set; }
        [JsonPropertyName("סמל_מועצה_איזורית")]
        public int RegionalCouncilCode { get; set; }
        [JsonPropertyName("שם_מועצה")]
        public string? RegionalCouncilName { get; set; }
    }

    public class Field
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class CityLinks
    {
        [JsonPropertyName("start")]
        public string? Start { get; set; }
        [JsonPropertyName("next")]
        public string? Next { get; set; }
    }
}
