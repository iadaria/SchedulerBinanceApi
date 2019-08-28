using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApiMvc.Data.API.Work.Interface;

namespace WebApiMvc.Data.API.Work
{
    public class GetDataFromApi<T> : IGetDataFromApi<T>
    {
        public async Task<T> GetDataAsync(
            string urlApi, 
            string pair,
            string limit = "")
        {
            WebClient web = new WebClient();

            string url = urlApi
                .Replace("pair", pair)
                .Replace("&limit=count", limit != "" ? $"&limit={limit}" : "");

            var data_byte = await web.DownloadDataTaskAsync(url);
            var data_str = System.Text.Encoding.UTF8.GetString(data_byte);

            return JsonConvert.DeserializeObject<T>(data_str);
        }
    }
}