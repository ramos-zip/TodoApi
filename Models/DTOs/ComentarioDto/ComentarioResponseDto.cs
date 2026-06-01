using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models.DTOs.ComentarioDto
{
    public class ComentarioResponseDto
    {
        public Guid Id { get; set; }
        public string Conteudo {get; set;} = string.Empty;
        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
        public Guid TarefaId { get; set;}
        public Guid UsuarioId { get; set; }
    }
}