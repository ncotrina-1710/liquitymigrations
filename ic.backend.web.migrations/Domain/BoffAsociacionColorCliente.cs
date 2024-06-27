using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffAsociacionColorCliente
{
    public int IdAsociacionColorCliente { get; set; }

    public int CustomizaElementoId { get; set; }

    public int ColorId { get; set; }

    public DateTime FecCreacion { get; set; }

    public DateTime? FecActualizacion { get; set; }

    public int IdUsuario { get; set; }

    public virtual BoffColore Color { get; set; } = null!;

    public virtual BendCustomizaElemento CustomizaElemento { get; set; } = null!;
}
