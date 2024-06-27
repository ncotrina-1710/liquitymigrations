using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffRepresentante
{
    public int IdRepresentante { get; set; }

    public int ClienteId { get; set; }

    public string NombreRepresentante { get; set; } = null!;

    public string EmailRepresentante { get; set; } = null!;

    public string TelefonoRepresentante { get; set; } = null!;

    public string DireccionRepresentante { get; set; } = null!;

    public int TipoDocumentoId { get; set; }

    public string NumeroDocumentoRepresentante { get; set; } = null!;

    public int EstadoRepresentante { get; set; }

    public DateTime FecCreacionRepresentante { get; set; }

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual BoffCliente Cliente { get; set; } = null!;

    public virtual ApliTipoDocumento TipoDocumento { get; set; } = null!;
}
