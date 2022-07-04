namespace WebApplication2.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Telefone { get; set; }

        public string NomeCompleto => $"{Nome} , {Apelido}";
    }
}
