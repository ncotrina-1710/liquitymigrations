using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffTipoEtapaMedidaCautelar
{
    public int IdTipoEtapaMedidaCautelar { get; set; }

    public int? NroOrdenEtapaMedidaCautelar { get; set; }

    public string NombreTipoEtapaMedidaCautelar { get; set; } = null!;

    public int EstadoTipoEtapaMedidaCautelar { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FecCreacionTipoEtapaMedidaCautelar { get; set; }

    public DateTime? FecActualizacionTipoEtapaMedidaCautelar { get; set; }

    public virtual ICollection<BoffTipoSubetapaMedidaCautelar> BoffTipoSubetapaMedidaCautelars { get; set; } = new List<BoffTipoSubetapaMedidaCautelar>();
}
