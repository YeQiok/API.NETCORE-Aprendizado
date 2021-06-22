using Refit;
using System.Threading.Tasks;

namespace API.NETCORE
{
    interface ICepApi
    {
        [Get("/ws/{cep}/json")]
        Task<CEPResponse> GetAddressAsync(string cep);
    }
}
