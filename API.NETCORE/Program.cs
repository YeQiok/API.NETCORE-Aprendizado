using Refit;
using System;
using System.Threading.Tasks;

namespace API.NETCORE
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var CepCliente = RestService.For<ICepApi>("http://viacep.com.br");
                Console.WriteLine("Informe seu CEP:");

                //Capturar CEP

                String CepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Verificando CEP Valido: " + CepInformado);

                //Chamada Refit
                var address = await CepCliente.GetAddressAsync(CepInformado);

                //Mostrando Informações
                Console.Write($"\nLogradouro: {address.Logradouro}\nBairro: {address.Bairro}\nLocalidade: {address.Localidade}\nUF: {address.UF}\nIBGE: {address.IBGE}\nGia: {address.Gia}\nDDD: {address.DDD}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta do Cep" + e.Message); 
            }
        }
    }
}
