using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    public interface IPokeApiService
    {
        [Get("/pokemon/{nome}")]
        Task<PokeResponse> GetPokeResponseAsync(string nome);
    }
}
