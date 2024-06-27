using System;
using System.Collections.Generic;

namespace Domain;

public partial class AsicMasivaLoteCargaErrore
{
    public int IdLotesCargaError { get; set; }

    public int NroFilaLote { get; set; }

    public string DescripcionCampoLote { get; set; } = null!;

    public string DescripcionErrorLote { get; set; } = null!;

    public int LoteId { get; set; }

    public DateTime FecCargaErrorLote { get; set; }

    public int? IdUsuario { get; set; }

    public virtual AsicMasivaLote Lote { get; set; } = null!;
}
