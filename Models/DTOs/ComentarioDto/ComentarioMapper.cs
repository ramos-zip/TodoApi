using System.ComponentModel.DataAnnotations;
using TodoApi.Models.Entities;

namespace TodoApi.Models.DTOs.ComentarioDto
{
    public static class ComentarioMapper
    { 
        public static ComentarioResponseDto ToResponse (this Comentario u) => new()
        {
            Id = u.Id,
            Conteudo = u.Conteudo,
            CriadoEm = u.CriadoEm,
            TarefaId = u.TarefaId,
            UsuarioId = u.UsuarioId
        };

        public static Comentario ToEntity(this ComentarioCreateDto dto) => new()
        {
            Id = Guid.NewGuid(),
            Conteudo = dto.Conteudo.Trim()
        };
    }
}