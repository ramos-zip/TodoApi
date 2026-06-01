namespace TodoApi.Models.Entities
{
    public class Tarefa
    {
        // Diferença Guid e INT
        // int: números inteiros. Ex: 1, 2 ,3 ,....
        // Guid: sequência aleatória. Ex: ...., 1298-9705-ikjl, .....
        public Guid Id { get; set; }
        public string Titulo { get;set; } = string.Empty;
        public string? Descricao { get;set; } = string.Empty;
        public bool Concluida { get; set; } = false;
        public DateTime DataCriacao { get; set;} = DateTime.UtcNow;
        public DateTime AtualizadaEm { get; set;} = DateTime.UtcNow;

        // Relação com Usuário: 1 Tarefa pertence a 1 Usuário
        public Guid UsuarioId { get; set;}
        public Usuario? Usuario { get; set;}
        public ICollection<Comentario>? Comentarios { get; set; }
    }
}