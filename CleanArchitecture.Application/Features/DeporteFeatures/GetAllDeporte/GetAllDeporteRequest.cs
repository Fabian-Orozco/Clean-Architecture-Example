using MediatR;

namespace CleanArchitecture.Application.Features.DeporteFeatures.GetAllDeporte;

public sealed record GetAllDeporteRequest : IRequest<List<GetAllDeporteResponse>>;