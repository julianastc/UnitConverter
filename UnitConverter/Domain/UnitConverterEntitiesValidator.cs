using FluentValidation;

namespace UnitConverter.Domain;

public class UnitConverterEntitiesValidator : AbstractValidator<UnitConverterEntities>
{
    public UnitConverterEntitiesValidator()
    {
        RuleFor(x => x.UnitValue).GreaterThan(0).WithMessage("O número deve ser maior que 0");
        RuleFor(x => x.InitialUnitType).IsInEnum().WithMessage("Opção inválida").NotEmpty()
            .WithMessage("Opção não pode ser vazia.");
        RuleFor(x => x.FinalConvertedUnitType).IsInEnum().WithMessage("Opção inválida").NotEmpty()
            .WithMessage("Opção não pode ser vazia");
    }
}