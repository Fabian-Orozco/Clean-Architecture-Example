namespace CleanArchitecture.Application.Features.DeporteFeatures.CreateDeporte;

public sealed record CreateDeporteResponse
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public int JugadoresPorEquipo { get; set; }
}