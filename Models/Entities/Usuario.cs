namespace TodoApi.Models.Entities
{
    public class Usuario
    {
        public Guid Id {get; set;}
        public string Nome {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
        public string PasswordHash {get; set;} = string.Empty;

        // Relação com Tarefas: Um Usuário realiza 1 ou mais Tarefas
        public ICollection<Tarefa> Tarefas {get; set;} = new List<Tarefa>();
        public ICollection<Comentario>? Comentarios {get; set;}
    }
}