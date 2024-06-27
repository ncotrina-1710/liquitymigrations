using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliMedidaCautelarExpediente
{
    public int IdMedidaCautelarExpediente { get; set; }

    public int? ExpedienteId { get; set; }

    public int? TipoMedidaCautelarId { get; set; }

    public int? TipoSubetapaMedidaCautelarId { get; set; }

    public int DemandadoId { get; set; }

    public string? DetalleMedidaCautelar { get; set; }

    public DateTime? CalendarioMedidaCautelarExpediente { get; set; }

    public string? NumeroOficioMedidaCautelarExpediente { get; set; }

    public decimal? ValorAvaluoMedidaCautelarExpediente { get; set; }

    public decimal? ValorRemateMedidaCautelarExpediente { get; set; }

    public DateTime? FecGestionMedidaCautelarExpdiente { get; set; }

    public DateTime FecCreacionedidaCautelarExpediente { get; set; }

    public int? UsuarioId { get; set; }

    public virtual ApliDemandado Demandado { get; set; } = null!;

    public virtual AsicExpediente? Expediente { get; set; }

    public virtual BoffTipoMedidasCautelare? TipoMedidaCautelar { get; set; }

    public virtual BoffTipoSubetapaMedidaCautelar? TipoSubetapaMedidaCautelar { get; set; }
}
