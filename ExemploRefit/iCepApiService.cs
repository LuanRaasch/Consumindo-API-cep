
using Refit;
using System.Threading.Tasks;

namespace ExemploRefit
{
    internal interface iCepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
