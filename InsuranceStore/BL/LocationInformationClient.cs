using InsuranceStore.DataObjects;
using System.Net.Http.Json;

namespace InsuranceStore.BL
{
    internal static class LocationInformationClient
    {
        private static readonly HttpClient client = new HttpClient();
        private const string cityAPI = "https://data.gov.il/api/3/action/datastore_search?resource_id=d4901968-dad3-4845-a9b0-a57d027f11ab";
        private const string streetAPI = "https://data.gov.il/api/3/action/datastore_search?resource_id=a7296d1a-f8c9-4b70-96c2-6ebb4352f8e3&q=";

        public static async Task<List<string>> GetCitiesAsync()
        {
            CityList? responseJson = await client.GetFromJsonAsync<CityList>(cityAPI);
            return responseJson.Result.Records
                .Where(record => record.SettlementName != null)
                .Select(record => record.SettlementName.Trim())
                .Distinct()
                .ToList();
        }

        public static async Task<List<string>> GetStreetsAsync(string city)
        {
            var responseJson = await client.GetFromJsonAsync<StreetList>(streetAPI + city);
            return responseJson.Result.Records
                .Where(record => record.SettlementName.Trim() == city)
                .Select(record => record.StreetName.Trim())
                .Distinct()
                .ToList();
        }
    }
}
