using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    public class PokeResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public string Altura  { get; set; }

        [JsonProperty("weight")]
        public string Peso { get; set; }
    }
}
