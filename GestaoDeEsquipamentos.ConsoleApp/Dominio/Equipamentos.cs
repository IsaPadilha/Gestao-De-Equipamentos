using System;

namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

public class Equipamentos
{
    public int id;
    public string nome;
    public decimal precoAquisicao;
    public DateTime dataFabricacao;

    // método construtor
    public Equipamentos(string nome, decimal precoAquisicao, DateTime dataFabricacao)
    {
        this.nome = nome;
        this.precoAquisicao = precoAquisicao;
        this.dataFabricacao = dataFabricacao;
    }
}
