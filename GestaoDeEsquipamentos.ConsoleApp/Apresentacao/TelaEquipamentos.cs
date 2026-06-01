using GestaoDeEquipamentos.ConsoleApp.Dominio;

namespace GestaoDeEquipamentos.ConsoleApp.Apresentacao;

public class TelaEquipamento
{
    public int contadorIdsEquipamentos = 1;
    public Equipamentos[] equipamentosSalvos = new Equipamentos[100];

    public string? ObterOpcaoMenu()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Controle de Equipamentos");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Cadastrar equipamento");
        Console.WriteLine("2 - Editar equipamento");
        Console.WriteLine("3 - Excluir equipamento");
        Console.WriteLine("4 - Visualizar equipamentos");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenu = Console.ReadLine()?.ToUpper();

        return opcaoMenu;
    }

    public void Cadastrar()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Controle de Equipamentos");
        Console.WriteLine("---------------------------------");
        Console.Write("Digite o nome do equipamento: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o preço de aquisição do equipamento: ");
        decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a data de fabricação do equipamento: ");
        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

        Equipamentos equipamento = new Equipamentos();
        equipamento.id = contadorIdsEquipamentos++;
        equipamento.nome = nome;
        equipamento.precoAquisicao = precoAquisicao;
        equipamento.dataFabricacao = dataFabricacao;

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            if (equipamentosSalvos[i] == null)
            {
                equipamentosSalvos[i] = equipamento;
                break;
            }
        }

        Console.WriteLine($"O equipamento {equipamento.nome} foi cadastrado com sucesso!");
        Console.ReadLine();
    }

    public void Editar()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Edição de Equipamento");
        Console.WriteLine("---------------------------------");

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
            "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
            );

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamentos eq = equipamentosSalvos[i];

            if (eq == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao.ToShortDateString()
            );
        }

        Console.WriteLine("---------------------------------");
        Console.Write("Digite o id do registro que deseja editar: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome do equipamento: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o preço de aquisição do equipamento: ");
        decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a data de fabricação do equipamento: ");
        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamentos equipamentoSelecionado = equipamentosSalvos[i];

            if (equipamentoSelecionado == null)
                continue;

            if (equipamentoSelecionado.id == idSelecionado)
            {
                equipamentoSelecionado.nome = nome;
                equipamentoSelecionado.precoAquisicao = precoAquisicao;
                equipamentoSelecionado.dataFabricacao = dataFabricacao;
                break;
            }
        }

        Console.WriteLine($"O equipamento {nome} foi editado com sucesso!");
        Console.ReadLine();
    }

    public void Excluir()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Exclusão de Equipamento");
        Console.WriteLine("---------------------------------");

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -20} | (3, -15)",
            "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
        );

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamentos eq = equipamentosSalvos[i];

            if (eq == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao.ToShortDateString()
            );
        }

        Console.WriteLine("---------------------------------");
        Console.Write("Digite o id do registro que deseja excluir: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamentos equipamentoSelecionado = equipamentosSalvos[i];

            if (equipamentoSelecionado == null)
                continue;

            if (equipamentoSelecionado.id == idSelecionado)
            {
                equipamentosSalvos[i] = null;
                break;
            }
        }

        Console.WriteLine($"O equipamento foi excluído com sucesso!");
        Console.ReadLine();
    }

    public void VizualizarTodos()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Vizualização de Equipamentos");
        Console.WriteLine("---------------------------------");

        Console.WriteLine(
            "{0, -7} | {1, -15} | (2, -20) | {3, -15}",
            "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
        );

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamentos eq = equipamentosSalvos[i];

            if (eq == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                eq.id, eq.nome, eq.dataFabricacao, eq.dataFabricacao.ToShortDateString()
            );
        }

        Console.WriteLine("---------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }
}