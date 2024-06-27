using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliVencimientoContrasenia
{
    public int IdVencimientoContrasenia { get; set; }

    public int CantVencimiento { get; set; }

    public int EstadoVencimientoContrasenia { get; set; }

    public DateTime FecCreacionVencimientoContrasenia { get; set; }

    public DateTime? FecActualizacionVencimientoContrasenia { get; set; }

    public int IdUsuario { get; set; }

    public virtual ICollection<ApliVencimientoContraseniasCliente> ApliVencimientoContraseniasClientes { get; set; } = new List<ApliVencimientoContraseniasCliente>();
}
