using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliAbogado
{
    public int IdAbogado { get; set; }

    public int UsuarioId { get; set; }

    public string? NombresAbogado { get; set; }

    public string? ApellidosAbogado { get; set; }

    public string? TarjetaProfesional { get; set; }

    public DateTime? FecInicioLicenciaAbogado { get; set; }

    public DateTime? FecFinLicenciaAbogado { get; set; }

    public DateTime? FecNacimientoAbogado { get; set; }

    public int? EstadoAbogado { get; set; }

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual BoffUsuario Usuario { get; set; } = null!;
}
