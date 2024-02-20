using MediatR;

namespace CleanArchitecture.Application.Features.DeporteFeatures.CreateDeporte;

public sealed record CreateDeporteRequest(string Nombre, int JugadoresPorEquipo) : IRequest<CreateDeporteResponse>;