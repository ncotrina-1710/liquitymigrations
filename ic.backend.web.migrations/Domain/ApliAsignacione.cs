using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliAsignacione
{
    public int IdAsignacion { get; set; }

    public int ExpedienteId { get; set; }

    public int UsuarioId { get; set; }

    public int TipoAsignacionId { get; set; }

    public DateTime FecCreacionAsignacion { get; set; }

    public DateTime? FecActualizacionAsignacion { get; set; }

    public virtual AsicExpediente Expediente { get; set; } = null!;

    public virtual ApliTipoAsignacione TipoAsignacion { get; set; } = null!;

    public virtual BoffUsuario Usuario { get; set; } = null!;
}
