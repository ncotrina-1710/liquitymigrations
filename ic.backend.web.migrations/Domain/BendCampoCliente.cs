using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendCampoCliente
{
    public int IdCampoCliente { get; set; }

    public int CampoId { get; set; }

    public int ClienteId { get; set; }

    public int EstadoCampoCliente { get; set; }

    public int OrdenCampo { get; set; }

    public virtual BendPlantillaCampo Campo { get; set; } = null!;

    public virtual BoffCliente Cliente { get; set; } = null!;
}
