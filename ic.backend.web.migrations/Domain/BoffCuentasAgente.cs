using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffCuentasAgente
{
    public int IdCuentaAgente { get; set; }

    public int CuentaId { get; set; }

    public string TipoAgente { get; set; } = null!;

    public string NombreAgente { get; set; } = null!;

    public string? EmailAgente { get; set; }

    public string? TelefonoAgente { get; set; }

    public string? DireccionAgente { get; set; }

    public int TipoDocumentoId { get; set; }

    public string NumeroDocumentoAgente { get; set; } = null!;

    public int PoderDemanda { get; set; }

    public int EstadoAgente { get; set; }

    public DateTime FecCreacionAgente { get; set; }

    public virtual BoffCuenta Cuenta { get; set; } = null!;

    public virtual ApliTipoDocumento TipoDocumento { get; set; } = null!;
}
