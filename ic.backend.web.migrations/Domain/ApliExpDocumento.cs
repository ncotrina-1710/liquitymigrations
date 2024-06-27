using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliExpDocumento
{
    public int IdExpDocumento { get; set; }

    public int TipoExpDocumentoId { get; set; }

    public int ExpedienteId { get; set; }

    public DateTime FecCreacionExpDocumento { get; set; }

    public string? UrlDocAdjunto { get; set; }

    public int UsuarioId { get; set; }

    public virtual AsicExpediente Expediente { get; set; } = null!;

    public virtual BendTipoExpDocumento TipoExpDocumento { get; set; } = null!;
}
