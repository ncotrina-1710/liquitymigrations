using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendDeudore
{
    public int IdDeudor { get; set; }

    public int TipoDocumentoId { get; set; }

    public string? NroDocumento { get; set; }

    public string? NombreDeudor { get; set; }

    public string? ApePaternoDeudor { get; set; }

    public string? ApeMaternoDeudor { get; set; }

    public DateTime? FecCreacionDeudor { get; set; }

    public int PaisId { get; set; }

    public virtual ICollection<BendDeudorBien> BendDeudorBiens { get; set; } = new List<BendDeudorBien>();

    public virtual ICollection<BendDeudorDeceval> BendDeudorDecevals { get; set; } = new List<BendDeudorDeceval>();

    public virtual ICollection<BendDeudorRamaJudicial> BendDeudorRamaJudicials { get; set; } = new List<BendDeudorRamaJudicial>();

    public virtual ICollection<BendDeudorSalario> BendDeudorSalarios { get; set; } = new List<BendDeudorSalario>();

    public virtual ICollection<BendDeudorVehiculo> BendDeudorVehiculos { get; set; } = new List<BendDeudorVehiculo>();

    public virtual ApliTipoDocumento TipoDocumento { get; set; } = null!;
}
