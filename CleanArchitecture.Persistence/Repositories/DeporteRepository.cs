using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;

public class DeporteRepository : BaseRepository<Deporte>, IDeporteRepository
{
    public DeporteRepository(DataContext context) : base(context)
    {
    }
    
    public Task<Deporte> GetByNombre(string nombre, CancellationToken cancellationToken)
    {
        return Context.Deportes.FirstOrDefaultAsync(x => x.Nombre == nombre, cancellationToken);
    }
}