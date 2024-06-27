using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendDeudorBien
{
    public int IdDeudorBien { get; set; }

    public int DeudorId { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? FecCreacionDeudorBien { get; set; }

    public virtual ICollection<BendHistBusqBienesDetalle> BendHistBusqBienesDetalles { get; set; } = new List<BendHistBusqBienesDetalle>();

    public virtual BendDeudore Deudor { get; set; } = null!;
}
