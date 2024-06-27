using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliDemandado
{
    public int IdDemandado { get; set; }

    public string? NombreDemandado { get; set; }

    public string? ApellidoPaternoDemandado { get; set; }

    public string? ApellidoMaternoDemandado { get; set; }

    public int TipoDocumentoId { get; set; }

    public string? NumeroDocumentoDemandado { get; set; }

    public string? EmailDemandado { get; set; }

    public string? DireccionDemandado { get; set; }

    public string? TelefonoDemandado { get; set; }

    public virtual ICollection<ApliMedidaCautelarExpediente> ApliMedidaCautelarExpedientes { get; set; } = new List<ApliMedidaCautelarExpediente>();

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual ApliTipoDocumento TipoDocumento { get; set; } = null!;
}
