using AplicacoesDistribuidas.Model;
using FluentValidation;

namespace AplicacoesDistribuidas.Utils.Validators
{
    public class AtualizarItemRequestValidator : AbstractValidator<AtualizarItemRequest>
    {
        public AtualizarItemRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("É necessário informar o Id do Item.")
                .GreaterThan(0).WithMessage("O Id do Projeto deve ser maior que 0");

            RuleFor(x => x.Nome).NotEmpty().WithMessage("É necessário informar o Nome");
            RuleFor(x => x.Valor).NotEmpty().WithMessage("É necessário informar o Valor");
        }
    }
}

