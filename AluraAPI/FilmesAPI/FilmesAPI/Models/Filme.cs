using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage ="O campo diretor é obrigatorio")]
        public string Diretor { get; set; }
       
        public string Genero { get; set; }
        [Range(1,600)]
        public int Duracao { get; set; }

    }
}
