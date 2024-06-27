using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendHistBusqSalariosDetalle
{
    public int IdHistBusqSalario { get; set; }

    public int DeudorSalarioId { get; set; }

    public int? EstadoSalario { get; set; }

    public string? EntidadSalario { get; set; }

    public string? TipoRegimenSalario { get; set; }

    public DateTime? FecAfilEfectiva { get; set; }

    public DateTime? FecAfilFinalizacion { get; set; }

    public string? TipoAfiliadoSalario { get; set; }

    public int? TipoDocumentoId { get; set; }

    public decimal? Salario { get; set; }

    public string? Empresa { get; set; }

    public string? DireccionEmpresa { get; set; }

    public string? NroDocumento { get; set; }

    public string? ErrorBusqueda { get; set; }

    public string? DetalleError { get; set; }

    public DateTime? FecBusqueda { get; set; }

    public string? Observacion { get; set; }

    public virtual BendDeudorSalario DeudorSalario { get; set; } = null!;

    public virtual ApliTipoDocumento? TipoDocumento { get; set; }
}
