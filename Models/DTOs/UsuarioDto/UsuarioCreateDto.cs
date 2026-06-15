using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models.DTOs.UsuarioDto
{
    public class UsuarioCreateDto
    {
        [Required, MinLength(3), MaxLength(50)]
        public string Nome { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(8), MaxLength(16)]
        public string Senha { get; set; }
    }
}