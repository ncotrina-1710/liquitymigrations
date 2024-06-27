using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendDeudorDeceval
{
    public int IdDeudorDeceval { get; set; }

    public int? DeudorId { get; set; }

    public int? ExpedienteId { get; set; }

    public DateTime? FecSolicitud { get; set; }

    public DateTime? FecRecepcion { get; set; }

    public string? EstadoDeceval { get; set; }

    public virtual ICollection<BendDeceval> BendDecevals { get; set; } = new List<BendDeceval>();

    public virtual BendDeudore? Deudor { get; set; }

    public virtual AsicExpediente? Expediente { get; set; }
}
