using System;
using System.Collections.Generic;

namespace Domain;

public partial class AsicExpedienteCargaErrore
{
    public int IdExpedienteCargaError { get; set; }

    public int NroFilaExpediente { get; set; }

    public string DescripcionCampoExpediente { get; set; } = null!;

    public string DescripcionErrorExpediente { get; set; } = null!;

    public int ExpedienteId { get; set; }

    public DateTime FecCargaErrorExpediente { get; set; }

    public int? IdUsuario { get; set; }

    public virtual AsicExpediente Expediente { get; set; } = null!;
}
