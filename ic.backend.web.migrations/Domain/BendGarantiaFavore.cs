using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendGarantiaFavore
{
    public int IdGarantiaFavor { get; set; }

    public string? IdentificacionAcreedor { get; set; }

    public DateTime? FecInscripcionGarantiaFavor { get; set; }

    public string? PatrimonioAutonomo { get; set; }

    public string? ConfeCamara { get; set; }

    public virtual ICollection<BendHistBusqVehiculosDetalle> BendHistBusqVehiculosDetalles { get; set; } = new List<BendHistBusqVehiculosDetalle>();
}
