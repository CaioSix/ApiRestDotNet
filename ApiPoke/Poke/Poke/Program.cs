using Refit;

namespace Poke
{
    class MainClass
    {
         static async Task Main(string[] args)
        {
            try
            {
                var PokeClient = RestService.For<IPokeApiService>("https://pokeapi.co/api/v2");
                Console.WriteLine("Informe seu pokemon:");

                string PokeInformado = Console.ReadLine().ToString();
                

                Console.WriteLine("Consultando informações do pokemon: " + PokeInformado);

                var resultado = await PokeClient.GetPokeResponseAsync(PokeInformado);

                

                Console.WriteLine($"Pokemon: {resultado.Name}");
                Console.WriteLine($"Altura: {resultado.Altura}");
                
                Console.WriteLine($"Peso: {resultado.Peso}");
                Console.WriteLine($"u todo: {resultado}");
            }
            catch(Exception e)
            {
                Console.WriteLine("erro na consulta do pokeon: " + e.Message);
            }




        }
    }
}