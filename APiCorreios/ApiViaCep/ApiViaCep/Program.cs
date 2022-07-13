using ApiViaCep;
using Refit;

namespace ApiViaCep
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            
            try
            {
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.WriteLine("Informe seu Cep: ");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informacoes: " + cepInformado);

                var address = await cepClient.GetAddressAsync(cepInformado);

                Console.WriteLine($"Logradouro:{address.Logradouro}," +
                    $"Bairro:{address.Bairro}," +
                    $"Cidade:{address.Localidade}");


            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de cep: " + e.Message);
            }
        }
    }
}