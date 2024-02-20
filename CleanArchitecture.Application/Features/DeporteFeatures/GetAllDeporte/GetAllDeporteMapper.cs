using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.DeporteFeatures.GetAllDeporte;

public sealed class GetAllDeporteMapper : Profile
{
    public GetAllDeporteMapper()
    {
        CreateMap<Deporte, GetAllDeporteResponse>();
    }
}