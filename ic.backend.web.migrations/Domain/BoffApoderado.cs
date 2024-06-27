using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffApoderado
{
    public int IdApoderado { get; set; }

    public int ClienteId { get; set; }

    public string NombreApoderado { get; set; } = null!;

    public string EmailApoderado { get; set; } = null!;

    public string TelefonoApoderado { get; set; } = null!;

    public string DireccionApoderado { get; set; } = null!;

    public int TipoDocumentoId { get; set; }

    public string NumeroDocumentoApoderado { get; set; } = null!;

    public int EstadoApoderado { get; set; }

    public DateTime FecCreacionApoderado { get; set; }

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual BoffCliente Cliente { get; set; } = null!;

    public virtual ApliTipoDocumento TipoDocumento { get; set; } = null!;
}
