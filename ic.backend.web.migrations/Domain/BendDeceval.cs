using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendDeceval
{
    public int IdDeceval { get; set; }

    public int? DeudorDecevalId { get; set; }

    public int? SedeId { get; set; }

    public int? CuentaId { get; set; }

    public string? Unidad { get; set; }

    public string? Mti { get; set; }

    public string? Digital { get; set; }

    public decimal? Valor { get; set; }

    public decimal? ValorInteres { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string? TipoPagare { get; set; }

    public string? TipoCertificado { get; set; }

    public string? Estado { get; set; }

    public string? Proceso { get; set; }

    public string? Enlace { get; set; }

    public string? Observacion { get; set; }

    public string? FecActualizacion { get; set; }

    public string? Activo { get; set; }

    public string? FecCreacion { get; set; }

    public string? Certficicado { get; set; }

    public string? FecExpedicion { get; set; }

    public virtual BoffCuenta? Cuenta { get; set; }

    public virtual BendDeudorDeceval? DeudorDeceval { get; set; }

    public virtual AsicSede? Sede { get; set; }
}
