using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliTipoDocumento
{
    public int IdTipoDocumento { get; set; }

    public string? NombreTipoDocumento { get; set; }

    public int TipoPersonaId { get; set; }

    public virtual ICollection<ApliDemandado> ApliDemandados { get; set; } = new List<ApliDemandado>();

    public virtual ICollection<ApliDemandante> ApliDemandantes { get; set; } = new List<ApliDemandante>();

    public virtual ICollection<BendDeudore> BendDeudores { get; set; } = new List<BendDeudore>();

    public virtual ICollection<BendHistBusqSalariosDetalle> BendHistBusqSalariosDetalles { get; set; } = new List<BendHistBusqSalariosDetalle>();

    public virtual ICollection<BoffApoderado> BoffApoderados { get; set; } = new List<BoffApoderado>();

    public virtual ICollection<BoffCliente> BoffClientes { get; set; } = new List<BoffCliente>();

    public virtual ICollection<BoffCuentasAgente> BoffCuentasAgentes { get; set; } = new List<BoffCuentasAgente>();

    public virtual ICollection<BoffRepresentante> BoffRepresentantes { get; set; } = new List<BoffRepresentante>();

    public virtual ICollection<BoffUsuario> BoffUsuarios { get; set; } = new List<BoffUsuario>();

    public virtual ICollection<GbotHistGestionBot> GbotHistGestionBots { get; set; } = new List<GbotHistGestionBot>();

    public virtual ICollection<GbotHistLogBot> GbotHistLogBots { get; set; } = new List<GbotHistLogBot>();

    public virtual ApliTipoPersona TipoPersona { get; set; } = null!;
}
