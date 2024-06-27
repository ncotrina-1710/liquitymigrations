using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendDeudorVehiculo
{
    public int IdDeudorVehiculo { get; set; }

    public int DeudorId { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? FecCreacion { get; set; }

    public DateTime? FecActualizacion { get; set; }

    public virtual ICollection<BendHistBusqVehiculosDetalle> BendHistBusqVehiculosDetalles { get; set; } = new List<BendHistBusqVehiculosDetalle>();

    public virtual BendDeudore Deudor { get; set; } = null!;
}
