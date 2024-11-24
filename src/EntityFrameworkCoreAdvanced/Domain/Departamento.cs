namespace EntityFrameworkCoreAdvanced.Domain;

public class Departamento
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public bool Ativo { get; set; }
    
    public List<Funcionario> Funcionarios { get; set; } = [];
}