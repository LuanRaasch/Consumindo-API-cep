using Refit;
using System;
using System.Threading.Tasks;

namespace ExemploRefit
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<iCepApiService>("http://viacep.com.br");
                Console.WriteLine("Informe seu cep:");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informações do CEP: " + cepInformado);

                var address = await cepClient.GetAddressAsync(cepInformado);

                Console.Write($"\nLogradouro:{address.Logradouro} \nBairro:{address.Bairro} \nCidade:{address.Localidade} \nIBGE:{address.Ibge}");
                Console.ReadKey();

            } catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de cep: " + e.Message);
            }
        }
    }
}
