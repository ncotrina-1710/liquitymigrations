using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendHistBusqBienesDetalle
{
    public int IdHistBusqBien { get; set; }

    public int DeudorBienId { get; set; }

    public string? Ciudad { get; set; }

    public string? Matricula { get; set; }

    public string? Direccion { get; set; }

    public string? Avaluo { get; set; }

    public string? OficinaRegistro { get; set; }

    public string? ErrorBusqueda { get; set; }

    public string? DetalleError { get; set; }

    public DateTime? FecCreacionBien { get; set; }

    public DateTime? FecBusqueda { get; set; }

    public int? Estado { get; set; }

    public string? Observacion { get; set; }

    public virtual BendDeudorBien DeudorBien { get; set; } = null!;
}
