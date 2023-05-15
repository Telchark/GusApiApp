using GusApiApp.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GusApiApp.Data
{
    public interface IAreaDataProvider
    {
        Task<IEnumerable<Area>?> GetAllAsync();
    }

    public class AreaDataProvider : IAreaDataProvider
    {
        public async Task<IEnumerable<Area>?> GetAllAsync()
        {
            using var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(15);
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api-dbw.stat.gov.pl/api/1.1.0/area/area-area");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Area>>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
    }
}
