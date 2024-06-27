using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendDeudorRamaJudicial
{
    public int IdDeudorRamaJudicial { get; set; }

    public int? DeudorId { get; set; }

    public string NroRadicacion { get; set; } = null!;

    public DateTime? FecInicioTermino { get; set; }

    public DateTime? FecFintTermino { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? FecRegistro { get; set; }

    public virtual ICollection<BendHistRamaJudicial> BendHistRamaJudicials { get; set; } = new List<BendHistRamaJudicial>();

    public virtual BendDeudore? Deudor { get; set; }
}
