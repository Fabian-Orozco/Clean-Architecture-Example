using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.DeporteFeatures.GetAllDeporte;

public sealed class GetAllDeporteHandler : IRequestHandler<GetAllDeporteRequest, List<GetAllDeporteResponse>>
{
    private readonly IDeporteRepository _deporteRepository;
    private readonly IMapper _mapper;

    public GetAllDeporteHandler(IDeporteRepository deporteRepository, IMapper mapper)
    {
        _deporteRepository = deporteRepository;
        _mapper = mapper;
    }
    
    public async Task<List<GetAllDeporteResponse>> Handle(GetAllDeporteRequest request, CancellationToken cancellationToken)
    {
        var deportes = await _deporteRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllDeporteResponse>>(deportes);
    }
}