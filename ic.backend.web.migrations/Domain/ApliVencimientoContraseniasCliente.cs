using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliVencimientoContraseniasCliente
{
    public int IdVencimientoContraseniaCliente { get; set; }

    public int ClienteId { get; set; }

    public int VencimientoContraseniaId { get; set; }

    public int EstadoVencimientoContraseniaCliente { get; set; }

    public DateTime FecCreacionVencimientoContraseniaCliente { get; set; }

    public DateTime? FecActualizacionVencimientoContraseniaCliente { get; set; }

    public int IdUsuario { get; set; }

    public virtual BoffCliente Cliente { get; set; } = null!;

    public virtual ApliVencimientoContrasenia VencimientoContrasenia { get; set; } = null!;
}
