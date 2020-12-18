using AplicacoesDistribuidas.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AplicacoesDistribuidas.Interfaces
{
    public interface ICardapioRepository
    {
        Task Cadastrar(CadastrarItemRequest request);

        Task<IEnumerable<ItemCardapio>> ObterCardapioCompleto();

        Task Atualizar(AtualizarItemRequest request);

        Task Excluir(int id);

        Task<ItemCardapio> ObterItem(int id);
    }
}
