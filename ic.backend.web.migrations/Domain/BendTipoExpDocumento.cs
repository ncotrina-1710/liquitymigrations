using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendTipoExpDocumento
{
    public int IdTipoExpDocumento { get; set; }

    public string DescripcionTipoExpDocumento { get; set; } = null!;

    public DateTime? FecCreacionTipoExpDocumento { get; set; }

    public virtual ICollection<ApliExpDocumento> ApliExpDocumentos { get; set; } = new List<ApliExpDocumento>();

    public virtual ICollection<BoffEstadoProcesalDocumento> BoffEstadoProcesalDocumentos { get; set; } = new List<BoffEstadoProcesalDocumento>();
}
