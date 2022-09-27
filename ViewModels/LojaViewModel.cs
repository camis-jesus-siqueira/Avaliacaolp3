namespace Avaliacaolp3.ViewModels;

public class LojaViewModel
{
    public string? Descricao { get; set; } 
    public string? Email { get; set; }
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Piso { get; set; }
    public string? Tipo { get; set; }

    public LojaViewModel(string? descricao, string? email, int id, string? nome, string? piso,  string? tipo)
    {
        Descricao = descricao;
        Email = email;
        Id = id;
        Nome = nome;
        Piso = piso;
        Tipo = tipo;
    }
}