using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendDeudorSalario
{
    public int IdDeudorSalario { get; set; }

    public int DeudorId { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? FecCreacionSaliario { get; set; }

    public virtual ICollection<BendHistBusqSalariosDetalle> BendHistBusqSalariosDetalles { get; set; } = new List<BendHistBusqSalariosDetalle>();

    public virtual BendDeudore Deudor { get; set; } = null!;
}
