using AplicacoesDistribuidas.Model;
using System.Threading.Tasks;

namespace AplicacoesDistribuidas.Interfaces
{
    public interface ICardapioService
    {
        Task<BaseResponse> Cadastrar(CadastrarItemRequest request);

        Task<BaseResponse> Atualizar(AtualizarItemRequest request);

        Task<BaseResponse> ObterCardapio();

        Task<BaseResponse> Excluir(int id);
    }
}
