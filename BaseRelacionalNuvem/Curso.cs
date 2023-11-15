public class Curso
{
    public int CursoId { get; set; }
    public string Nome { get; set; }
    public List<Estudante> Estudantes { get; set; } = new List<Estudante>();
}