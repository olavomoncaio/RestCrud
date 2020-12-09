using AplicacoesDistribuidas.Interfaces;
using AplicacoesDistribuidas.Model;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacoesDistribuidas.Services
{
    public class CardapioService : ICardapioService
    {
        private readonly ICardapioRepository _cardapioRepository;

        public CardapioService(ICardapioRepository cardapioRepository)
        {
            _cardapioRepository = cardapioRepository;
        }

        public async Task<BaseResponse> Cadastrar(CadastrarItemRequest request)
        {
            await _cardapioRepository.Cadastrar(request);

            return new BaseResponse { StatusCode = StatusCodes.Status200OK, Mensagem = $"Item criado com sucesso!"};
        }

        public async Task<BaseResponse> Atualizar(AtualizarItemRequest request)
        {
            await _cardapioRepository.Atualizar(request);

            return new BaseResponse { StatusCode = StatusCodes.Status200OK, Mensagem = $"Item atualizado com sucesso!" };
        }

        public async Task<BaseResponse> ObterCardapio()
        {
            var cardapio = await _cardapioRepository.ObterCardapioCompleto();

            return new ObterCardapioResponse() { Itens = cardapio.ToList(), StatusCode = StatusCodes.Status200OK, Mensagem = "Cardápio Obtido!" };
        }

        public async Task<BaseResponse> Excluir(int id)
        {
            await _cardapioRepository.Excluir(id);

            return new BaseResponse { StatusCode = StatusCodes.Status200OK, Mensagem = $"Item excluido com sucesso!" };
        }
    }
}
