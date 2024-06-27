using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffEstadoProcesalDocumento
{
    public int IdEstadoProcesalDocumento { get; set; }

    public int TipoExpDocumentoId { get; set; }

    public int EstatusProcesoId { get; set; }

    public int EstadoDocumento { get; set; }

    public DateTime FecCreacionEstadoProcesalDocumento { get; set; }

    public DateTime? FecActulacionEntregaDocumento { get; set; }

    public int UsuarioId { get; set; }

    public virtual ApliEstatusProceso EstatusProceso { get; set; } = null!;

    public virtual BendTipoExpDocumento TipoExpDocumento { get; set; } = null!;

    public virtual BoffUsuario Usuario { get; set; } = null!;
}
