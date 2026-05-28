namespace TodoApi.Models.Entities
{
    public class Comentario
    {
        //Guid: sequência aleatória. Ex: ..., 1298-9705-ikjl, ...
        public Guid Id {get; set;}
        public string Conteudo {get; set;} = string.Empty;
        public DateTime CriadoEm {get; set;} = DateTime.UtcNow;

        // fk - 1 Tarefa pode ter N comentários
        public Guid TarefaId {get; set;}
        public Tarefa? Tarefa {get; set;}

        // fk - 1 Usuário pode ter N comentários
        public Guid UsuarioId {get; set;}
        public Usuario? Usuario {get; set;}
    }
}