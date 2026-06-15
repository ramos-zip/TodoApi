using System.ComponentModel.DataAnnotations;
using TodoApi.Models.Entities;

namespace TodoApi.Models.DTOs.TarefaDto
{
    public static class TarefaMapper
    {
        public static TarefaResponseDto ToResponse(this Tarefa t) => new()
        {
            Id = t.Id,
            Titulo = t.Titulo,
            Descricao = t.Descricao,
            Concluida = t.Concluida,
            DataCriacao = t.DataCriacao,
            AtualizadaEm = t.AtualizadaEm,
            UsuarioId = t.UsuarioId
        };

       public static Tarefa ToEntity(this TarefaCreateDto dto, Guid usuarioId) => new()
       {
           Id = Guid.NewGuid(),
           Titulo = dto.Titulo.Trim(),
           Descricao = dto.Descricao,
           DataCriacao = DateTime.UtcNow,
           UsuarioId = usuarioId
       };
    }
}