using System.Collections.Specialized;
using GestaoDeEquipamentos.ConsoleApp.Utilidades;

namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

public class Chamado
{
    public int Id { get; private set; }
    public string Titulo { get; private set; }
    public string Descricao { get; private set; }
    public DateTime DataAbertura { get; private set; }
    public Equipamentos Equipamentos { get; private set; }

    public Chamado(string titulo, string descricao, Equipamentos equipamentos)
    {
        Id = GeradorIds.ObterIdChamado();

        Titulo = titulo;
        Descricao = descricao;
        Equipamentos = equipamentos;

        DataAbertura = DateTime.Now;
    }

    public void Atualizar(Chamado chamadoAtualizado)
    {
        Titulo = chamadoAtualizado.Titulo;
        Descricao = chamadoAtualizado.Descricao;
        Equipamentos = chamadoAtualizado.Equipamentos;
    }
}