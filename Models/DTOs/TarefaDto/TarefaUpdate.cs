using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models.DTOs.TarefaDto
{
    public class TarefaUpdateDto
    {
       
        public string Titulo {get; set;} = string.Empty;
        public string? Descricao {get; set;} = string.Empty; // ? = Campo Opicional
        public bool Concluida {get; set;} // bool = true or false
    }
}