using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendActividade
{
    public int Id { get; set; }

    public string IdExpediente { get; set; } = null!;

    public long IdWorkFlow { get; set; }

    public string IdActividad { get; set; } = null!;

    public int? IdRol { get; set; }

    public string? Status { get; set; }

    public int IdUsuario { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime FechaAsignacion { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaTermino { get; set; }

    public DateTime? FechaCancelacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public DateTime? FechaReingreso { get; set; }

    public DateTime FechaAlta { get; set; }

    public bool Activo { get; set; }

    public DateTime? FechaSuspension { get; set; }

    public DateTime? FechaReactivacion { get; set; }

    public bool? Permiso { get; set; }

    public long? IdReproceso { get; set; }

    public bool? EsDetenido { get; set; }
}
