using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models.DTOs.TarefaDto
{
    public class TarefaMapper
    {
        public string Titulo {get; set;} = string.Empty;
         public string? Descricao {get; set;} = string.Empty;
    }
}