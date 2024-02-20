using AutoMapper;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.DeporteFeatures.CreateDeporte;

public sealed class CreateDeporteHandler : IRequestHandler<CreateDeporteRequest, CreateDeporteResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDeporteRepository _deporteRepository;
    private readonly IMapper _mapper;

    public CreateDeporteHandler(IUnitOfWork unitOfWork, IDeporteRepository deporteRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _deporteRepository = deporteRepository;
        _mapper = mapper;
    }
    
    public async Task<CreateDeporteResponse> Handle(CreateDeporteRequest request, CancellationToken cancellationToken)
    {
        var deporte = _mapper.Map<Deporte>(request);
        _deporteRepository.Create(deporte);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreateDeporteResponse>(deporte);
    }
}