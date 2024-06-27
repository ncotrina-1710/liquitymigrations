using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliJuzgado
{
    public int IdJuzgado { get; set; }

    public int LocacionJuzgadoId { get; set; }

    public int? NroJuzgado { get; set; }

    public string? CodigoJuzgado { get; set; }

    public string? NombreJuzgado { get; set; }

    public string? CorreoElectronico { get; set; }

    public int EstadoJuzgado { get; set; }

    public DateTime FecCreacionJuzgado { get; set; }

    public DateTime? FecActualizacionJuzgado { get; set; }

    public int? UsuarioId { get; set; }

    public virtual ICollection<ApliJuzgadoExpediente> ApliJuzgadoExpedientes { get; set; } = new List<ApliJuzgadoExpediente>();

    public virtual ICollection<BendEstadoElectronicosRj> BendEstadoElectronicosRjs { get; set; } = new List<BendEstadoElectronicosRj>();

    public virtual ICollection<BendHistRamaJudicial> BendHistRamaJudicials { get; set; } = new List<BendHistRamaJudicial>();

    public virtual ApliLocacionJuzgado LocacionJuzgado { get; set; } = null!;
}
