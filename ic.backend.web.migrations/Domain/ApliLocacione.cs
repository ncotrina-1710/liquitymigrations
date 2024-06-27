using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliLocacione
{
    public int IdLocacion { get; set; }

    public int SedeId { get; set; }

    public string? PaisLocacion { get; set; }

    public string? Prefijo2Locacion { get; set; }

    public string? Prefijo3Locacion { get; set; }

    public string? RegionLocacion { get; set; }

    public string? ProvinciaLocacion { get; set; }

    public string? CiudadLocacion { get; set; }

    public double? LatitudLocacion { get; set; }

    public double? LongitudLocacion { get; set; }

    public string? PrefijoNumericoLocacion { get; set; }

    public string? ZonaHorariaLocacion { get; set; }

    public virtual ICollection<BendHistValidacione> BendHistValidaciones { get; set; } = new List<BendHistValidacione>();

    public virtual ICollection<BoffCliente> BoffClientes { get; set; } = new List<BoffCliente>();

    public virtual AsicSede Sede { get; set; } = null!;
}
