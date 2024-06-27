using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffTipoMedidasCautelare
{
    public int IdTipoMedidaCautelar { get; set; }

    public string DescripcionTipoMedidaCautelar { get; set; } = null!;

    public int EstadoTipoMedidaCautelar { get; set; }

    public DateTime FecCreacionTipoMedidaCautelar { get; set; }

    public DateTime? FecActualizacionTipoMedidaCautelar { get; set; }

    public virtual ICollection<ApliMedidaCautelarExpediente> ApliMedidaCautelarExpedientes { get; set; } = new List<ApliMedidaCautelarExpediente>();
}
