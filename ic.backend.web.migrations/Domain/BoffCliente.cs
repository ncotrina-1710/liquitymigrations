using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public partial class BoffCliente
{
    public int IdCliente { get; set; }

    public string NombreCliente { get; set; } = null!;

    public string EmailCliente { get; set; } = null!;

    public int TipoPersonaId { get; set; }

    public int TipoDocumentoId { get; set; }

    public string NumeroDocumentoCliente { get; set; } = null!;

    public int EstadoCliente { get; set; }

    public int LocacionId { get; set; }

    public string? RutaLogoCliente { get; set; }

    public string DireccionCliente { get; set; } = null!;

    public DateTime FecCreacionCliente { get; set; }

    public virtual ICollection<ApliDirectorio> ApliDirectorios { get; set; } = new List<ApliDirectorio>();

    public virtual ICollection<ApliVencimientoContraseniasCliente> ApliVencimientoContraseniasClientes { get; set; } = new List<ApliVencimientoContraseniasCliente>();

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual ICollection<AsicMasivaLote> AsicMasivaLotes { get; set; } = new List<AsicMasivaLote>();

    public virtual ICollection<BendCampoCliente> BendCampoClientes { get; set; } = new List<BendCampoCliente>();

    public virtual ICollection<BoffApoderado> BoffApoderados { get; set; } = new List<BoffApoderado>();

    public virtual ICollection<BoffColore> BoffColores { get; set; } = new List<BoffColore>();

    public virtual ICollection<BoffConfigCliente> BoffConfigClientes { get; set; } = new List<BoffConfigCliente>();

    public virtual ICollection<BoffCuenta> BoffCuenta { get; set; } = new List<BoffCuenta>();

    public virtual ICollection<BoffRepresentante> BoffRepresentantes { get; set; } = new List<BoffRepresentante>();

    public virtual ICollection<BoffUsuario> BoffUsuarios { get; set; } = new List<BoffUsuario>();

    public virtual ApliLocacione Locacion { get; set; } = null!;

    public virtual ApliTipoDocumento TipoDocumento { get; set; } = null!;

    public virtual ApliTipoPersona TipoPersona { get; set; } = null!;
    [NotMapped]
    public int TotalRegistros { get; set; }
}
