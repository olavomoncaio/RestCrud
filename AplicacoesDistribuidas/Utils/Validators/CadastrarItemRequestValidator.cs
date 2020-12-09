using AplicacoesDistribuidas.Model;
using FluentValidation;

namespace AplicacoesDistribuidas.Utils.Validators
{
    public class CadastrarItemRequestValidator : AbstractValidator<CadastrarItemRequest>
    {
        public CadastrarItemRequestValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("É necessário informar o Nome");
            RuleFor(x => x.Valor).NotEmpty().WithMessage("É necessário informar o Valor");
        }
    }
}
