using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliTipoPersona
{
    public int IdTipoPersona { get; set; }

    public string? DescripcionTipoPersona { get; set; }

    public virtual ICollection<ApliDemandante> ApliDemandantes { get; set; } = new List<ApliDemandante>();

    public virtual ICollection<ApliTipoDocumento> ApliTipoDocumentos { get; set; } = new List<ApliTipoDocumento>();

    public virtual ICollection<BoffCliente> BoffClientes { get; set; } = new List<BoffCliente>();
}
