using FluentValidation;

namespace CleanArchitecture.Application.Features.DeporteFeatures.CreateDeporte;

public sealed class CreateDeporteValidator : AbstractValidator<CreateDeporteRequest>
{
    public CreateDeporteValidator()
    {
        RuleFor(x => x.Nombre).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(x => x.JugadoresPorEquipo).NotEmpty().GreaterThan(0);
    }
}