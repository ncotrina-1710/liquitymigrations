using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliEvento
{
    public int IdEvento { get; set; }

    public string CodigoEvento { get; set; } = null!;

    public string NombreEvento { get; set; } = null!;

    public int TipoEventoId { get; set; }

    public int EstadoEvento { get; set; }

    public bool ControlWeb { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FecCreacionEvento { get; set; }

    public DateTime? FecActualizacionEvento { get; set; }

    public virtual ICollection<ApliDetalleExpedienteEvento> ApliDetalleExpedienteEventos { get; set; } = new List<ApliDetalleExpedienteEvento>();

    public virtual ApliTipoEvento TipoEvento { get; set; } = null!;
}
