using CleanArchitecture.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CleanArchitecture.Domain.Entities;

public sealed class Deporte : BaseEntity
{
    /// <summary>
    /// Representa el nombre del deporte.
    /// </summary>
    [Required(ErrorMessage = "Es necesario asignar un nombre")]
    [DisplayName("Nombre")]
    public string? Nombre { get; set; }

    /// <summary>
    /// Representa la cantidad de jugadores que puede tener cada equipo.
    /// </summary>
    [Required(ErrorMessage = "Es necesario asignar un valor")]
    [RegularExpression("^[0-9]+$", ErrorMessage = "Ingrese una cantidad válida")]
    [DisplayName("Jugadores por equipo")]
    public int JugadoresPorEquipo { get; set; }
}