using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.DeporteFeatures.CreateDeporte;

public sealed class CreateDeporteMapper : Profile
{
    public CreateDeporteMapper()
    {
        CreateMap<CreateDeporteRequest, Deporte>();
        CreateMap<Deporte, CreateDeporteResponse>();
    }
}