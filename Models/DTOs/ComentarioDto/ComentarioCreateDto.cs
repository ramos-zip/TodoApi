using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models.DTOs.ComentarioDto
{
    public class ComentarioCreateDto
    {
        [Required(ErrorMessage = "Comentário é obrigatório!")]
        public string Conteudo {get; set;} = string.Empty;
    }
}