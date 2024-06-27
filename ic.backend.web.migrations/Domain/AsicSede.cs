using System;
using System.Collections.Generic;

namespace Domain;

public partial class AsicSede
{
    public int IdSede { get; set; }

    public string PaisSede { get; set; } = null!;

    public string DepartamentoSede { get; set; } = null!;

    public string ProvinciaSede { get; set; } = null!;

    public int EstadoSede { get; set; }

    public virtual ICollection<ApliLocacione> ApliLocaciones { get; set; } = new List<ApliLocacione>();

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual ICollection<BendDeceval> BendDecevals { get; set; } = new List<BendDeceval>();

    public virtual ICollection<BendHistRamaJudicial> BendHistRamaJudicials { get; set; } = new List<BendHistRamaJudicial>();
}
