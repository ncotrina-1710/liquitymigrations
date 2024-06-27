using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliDemandante
{
    public int IdDemandante { get; set; }

    public string? NombreDemandante { get; set; }

    public int TipoPersonaId { get; set; }

    public int TipoDocumentoId { get; set; }

    public string? NumeroDocumentoDemandante { get; set; }

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual ApliTipoDocumento TipoDocumento { get; set; } = null!;

    public virtual ApliTipoPersona TipoPersona { get; set; } = null!;
}
