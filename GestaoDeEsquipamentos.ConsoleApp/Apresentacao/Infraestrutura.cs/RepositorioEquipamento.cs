using GestaoDeEquipamentos.ConsoleApp.Dominio;

namespace GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

public class RepositorioEquipamento // armazém / recipiente
{
    private Equipamentos[] equipamentosSalvos = new Equipamentos[100];

    public void Cadastrar(Equipamentos novoEquipamento)
    {
        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            if (equipamentosSalvos[i] == null)
            {
                equipamentosSalvos[i] = novoEquipamento;
                break;
            }
        }
    }

    public void Editar(int idSelecionado, Equipamentos equipamentoAtualizado)
    {
        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamentos equipamentoSelecionado = equipamentosSalvos[i];

            if (equipamentoSelecionado == null)
                continue;

            if (equipamentoSelecionado.Id == idSelecionado)
            {
                equipamentoAtualizado.Atualizar(equipamentoAtualizado);
                break;
            }
        }
    }

    public void Excluir(int idSelecionado)
    {
        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamentos equipamentoSelecionado = equipamentosSalvos[i];

            if (equipamentoSelecionado == null)
                continue;

            if (equipamentoSelecionado.Id == idSelecionado)
            {
                equipamentosSalvos[i] = null;
                break;
            }
        }
    }

    public Equipamentos[] SelecionarTodos()
    {
        return equipamentosSalvos;
    }
}