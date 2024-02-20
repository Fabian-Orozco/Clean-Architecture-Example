using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Repositories;

public interface IDeporteRepository : IBaseRepository<Deporte>
{
    Task<Deporte> GetByNombre(string nombre, CancellationToken cancellationToken);
}