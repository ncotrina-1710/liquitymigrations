using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendHistBusqVehiculosDetalle
{
    public int IdHistBusqVehiculo { get; set; }

    public int DeudorVehiculoId { get; set; }

    public string? NroPlacaVehiculo { get; set; }

    public int? LimitacionPropiedadId { get; set; }

    public int? GarantiaFavorId { get; set; }

    public string? EstadoRuntVehiculo { get; set; }

    public string? MarcaVehiculo { get; set; }

    public string? ModeloVehiculo { get; set; }

    public string? NroSerieVehiculo { get; set; }

    public string? NroChasisVehiculo { get; set; }

    public string? CilindrajeVehiculo { get; set; }

    public string? CombustibleVehiculo { get; set; }

    public string? AutoridadTransitoVehiculo { get; set; }

    public string? ClasicoAntiguoVehiculo { get; set; }

    public string? LineaVehiculo { get; set; }

    public string? ColorVehiculo { get; set; }

    public string? NroMotorVehiculo { get; set; }

    public string? NroVinVehiculo { get; set; }

    public string? TipoCarroceriaVehiculo { get; set; }

    public DateTime? FecMatriculaInicialVehiculo { get; set; }

    public string? GravemenesPropiedad { get; set; }

    public string? RepotenciadoVehiculo { get; set; }

    public string? CiudadVehiculo { get; set; }

    public string? OficinaRegistro { get; set; }

    public string? OtrasCaracteristicas { get; set; }

    public string? ErrorBusqueda { get; set; }

    public string? DetalleError { get; set; }

    public int? EstadoVehiculo { get; set; }

    public string? EstadoLimPropiedadVehiculo { get; set; }

    public string? EstadoGarFavorDe { get; set; }

    public string? Observacion { get; set; }

    public virtual BendDeudorVehiculo DeudorVehiculo { get; set; } = null!;

    public virtual BendGarantiaFavore? GarantiaFavor { get; set; }

    public virtual BendLimitacionPropiedade? LimitacionPropiedad { get; set; }
}
