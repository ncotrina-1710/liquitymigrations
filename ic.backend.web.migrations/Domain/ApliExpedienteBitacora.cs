using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliExpedienteBitacora
{
    public int IdBitacoraExpediente { get; set; }

    public int ExpedienteId { get; set; }

    public int TipoBitacoraId { get; set; }

    public string? DescripcionBitacora { get; set; }

    public DateTime? FecSeguimiento { get; set; }

    public DateTime FecRegistro { get; set; }

    public TimeSpan HoraRegistro { get; set; }

    public int? EstadoBitacora { get; set; }

    public int? UsuarioId { get; set; }

    public virtual AsicExpediente Expediente { get; set; } = null!;

    public virtual BoffTipoBitacora TipoBitacora { get; set; } = null!;
}
