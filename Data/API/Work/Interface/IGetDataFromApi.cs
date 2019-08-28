using System.Threading.Tasks;

namespace WebApiMvc.Data.API.Work.Interface
{
    public interface IGetDataFromApi<T>
    {
         Task<T> GetDataAsync(string urlApi, string pair, string limit);
    }
}