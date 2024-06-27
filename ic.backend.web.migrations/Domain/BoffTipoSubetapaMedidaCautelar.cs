using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffTipoSubetapaMedidaCautelar
{
    public int IdTipoSubetapaMedidaCautelar { get; set; }

    public int NroOrdenSubetapaMedidaCautelar { get; set; }

    public int TipoEtapaMedidaCautelarId { get; set; }

    public string NombreSubetapaMedidaCautelar { get; set; } = null!;

    public int EstadoSubetapaMedidaCautelar { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FecCreacionSubetapaMedidaCautelar { get; set; }

    public DateTime? FecActualizacionSubetapaMedidaCautelar { get; set; }

    public virtual ICollection<ApliMedidaCautelarExpediente> ApliMedidaCautelarExpedientes { get; set; } = new List<ApliMedidaCautelarExpediente>();

    public virtual BoffTipoEtapaMedidaCautelar TipoEtapaMedidaCautelar { get; set; } = null!;
}
