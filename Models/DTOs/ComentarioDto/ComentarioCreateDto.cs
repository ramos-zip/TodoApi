using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models.DTOs.ComentarioDto
{
    public class ComentarioCreateDto
    {
        [Required(ErrorMessage = "Comentario é obrigatorio!")]
       public string Conteudo {get; set;} = string.Empty;
    }
}