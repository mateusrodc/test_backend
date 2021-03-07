using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Computer
    {
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 1 a 60 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 a 60 caracteres")]
        public string Marca {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]

        public string Modelo {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]

        public string PlacaMae {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]

        public string MemoriaRam {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]

        public string Hd {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]

        public string VelocidadeProcessador {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(250, ErrorMessage = "Este campo deve conter entre 3 a 250 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 a 250 caracteres")]

        public string Foto {get; set;}
    }
}