using CleanArchitecture.Application.Features.DeporteFeatures.CreateDeporte;
using CleanArchitecture.Application.Features.DeporteFeatures.GetAllDeporte;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[ApiController]
[Route("deporte")]
public class DeporteController : ControllerBase
{
    private readonly IMediator _mediator;

    public DeporteController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllDeporteResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllDeporteRequest(), cancellationToken);
        return Ok(response);
    }
    
    [HttpPost]
    public async Task<ActionResult<CreateDeporteResponse>> Create(CreateDeporteRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}