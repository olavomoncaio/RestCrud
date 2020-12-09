using System.Collections.Generic;

namespace AplicacoesDistribuidas.Model
{
    public class ObterCardapioResponse :  BaseResponse
    {
        public List<ItemCardapio> Itens { get; set; }
    }
}
