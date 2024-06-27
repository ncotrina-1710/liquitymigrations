using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendCustomizaElemento
{
    public int IdCustomizaElemento { get; set; }

    public string Nombre { get; set; } = null!;

    public string TipoColor { get; set; } = null!;

    public DateTime FecCreacion { get; set; }

    public DateTime? FecActualizacion { get; set; }

    public int IdUsuario { get; set; }

    public virtual ICollection<BoffAsociacionColorCliente> BoffAsociacionColorClientes { get; set; } = new List<BoffAsociacionColorCliente>();
}
