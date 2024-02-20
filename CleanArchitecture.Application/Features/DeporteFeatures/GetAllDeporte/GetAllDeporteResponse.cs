namespace CleanArchitecture.Application.Features.DeporteFeatures.GetAllDeporte;

public sealed record GetAllDeporteResponse
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public int JugadoresPorEquipo { get; set; }
}