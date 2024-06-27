using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliPagaresExpediente
{
    public int IdPagareExpediente { get; set; }

    public int PagareId { get; set; }

    public int ExpedienteId { get; set; }

    public decimal? CapitalPagareExpediente { get; set; }

    public decimal? InteresPagareExpediente { get; set; }

    public decimal? OtroValoresPagareExpediente { get; set; }

    public decimal? ValorPagareExpediente { get; set; }

    public string? ObligacionPagareExpediente { get; set; }

    public DateTime? FecVencimientoPagareExpediente { get; set; }

    public DateTime? FecPrescripcionPagareExpediente { get; set; }

    public DateTime FecCreacionPagareExpediente { get; set; }

    public DateTime? FecActualizacionPagareExpediente { get; set; }

    public int? UsuarioId { get; set; }

    public virtual AsicExpediente Expediente { get; set; } = null!;

    public virtual ApliPagare Pagare { get; set; } = null!;
}
