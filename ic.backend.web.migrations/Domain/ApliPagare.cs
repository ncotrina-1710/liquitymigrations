using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliPagare
{
    public int IdPagare { get; set; }

    public string NroPagare { get; set; } = null!;

    public int TipoPagareId { get; set; }

    public DateTime FecCreacionPagare { get; set; }

    public int? IdUsuario { get; set; }

    public virtual ICollection<ApliPagaresExpediente> ApliPagaresExpedientes { get; set; } = new List<ApliPagaresExpediente>();

    public virtual ApliTipoPagare TipoPagare { get; set; } = null!;
}
