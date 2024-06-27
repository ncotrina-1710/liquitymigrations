using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliEstatusProceso
{
    public int IdEstatusProceso { get; set; }

    public int ExpedienteId { get; set; }

    public int EstadoProcesalId { get; set; }

    public int EstadoEstatusProceso { get; set; }

    public DateTime FecCreacionEstatusProceso { get; set; }

    public DateTime? FecActualizacionEstatusProceso { get; set; }

    public int UsuarioId { get; set; }

    public virtual ICollection<BoffEstadoProcesalDocumento> BoffEstadoProcesalDocumentos { get; set; } = new List<BoffEstadoProcesalDocumento>();

    public virtual ApliEstadoProcesal EstadoProcesal { get; set; } = null!;

    public virtual AsicExpediente Expediente { get; set; } = null!;

    public virtual BoffUsuario Usuario { get; set; } = null!;
}
