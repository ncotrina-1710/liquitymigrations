using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendLimitacionPropiedade
{
    public int IdLimitacionPropiedad { get; set; }

    public string? TipoLimitacionPropiedad { get; set; }

    public string? NroOficio { get; set; }

    public string? EntidadJuridica { get; set; }

    public string? Departamento { get; set; }

    public string? Municipio { get; set; }

    public DateTime? FecExpedicionOficio { get; set; }

    public DateTime? FecRegistroSistema { get; set; }

    public virtual ICollection<BendHistBusqVehiculosDetalle> BendHistBusqVehiculosDetalles { get; set; } = new List<BendHistBusqVehiculosDetalle>();
}
