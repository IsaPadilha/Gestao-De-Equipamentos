using GestaoDeEquipamentos.ConsoleApp.Utilidades;
namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

public class Equipamentos
{
    public int Id { get; private set; } // propriedade autoimplementada
    public string Nome { get; private set; }
    public decimal PrecoAquisicao { get; private set; }
    public DateTime DataFabricacao { get; private set; }

    // método construtor
    public Equipamentos(string nome, decimal precoAquisicao, DateTime dataFabricacao)
    {
        Id = GeradorIds.ObterIdEquipamento();

        Nome = nome;
        PrecoAquisicao = precoAquisicao;
        DataFabricacao = dataFabricacao;
    }

    public void Atualizar(Equipamentos equipamentoAtualizado)
    {
        Nome = equipamentoAtualizado.Nome;
        PrecoAquisicao = equipamentoAtualizado.PrecoAquisicao;
        DataFabricacao = equipamentoAtualizado.DataFabricacao;
    }
}
