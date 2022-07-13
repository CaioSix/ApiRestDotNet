using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {

        private static List<Filme> filmes = new List<Filme>();
        public static int id = 1;


        [HttpPost]
        public void AdicionarFilme([FromBody] Filme filme)
        {
            
            filme.Id = id++;
            filmes.Add(filme);
            Console.WriteLine($"o filme: {filme.Titulo} foi adicionado");
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {
            return filmes;
        }

        [HttpGet("{id}")]
        public Filme RecuperarFilmesPoId(int id)
        {
            foreach(Filme filme in filmes)
            {
                if(filme.Id == id)
                {
                    return filme;
                }
            }
            return null;
        }
    }
}
