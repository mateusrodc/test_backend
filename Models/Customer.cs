using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Customer
    {
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]
        public string Usuario {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]

        public string Senha {get; set;}
    }
}