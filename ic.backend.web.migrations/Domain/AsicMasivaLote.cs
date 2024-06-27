using System;
using System.Collections.Generic;

namespace Domain;

public partial class AsicMasivaLote
{
    public int IdLote { get; set; }

    public string NombreLote { get; set; } = null!;

    public int ClienteId { get; set; }

    public int EstadoLotes { get; set; }

    public DateTime FecCreacionLote { get; set; }

    public DateTime? FecActualizacionLote { get; set; }

    public virtual ICollection<AsicMasivaCabecera> AsicMasivaCabeceras { get; set; } = new List<AsicMasivaCabecera>();

    public virtual ICollection<AsicMasivaLoteCargaErrore> AsicMasivaLoteCargaErrores { get; set; } = new List<AsicMasivaLoteCargaErrore>();

    public virtual BoffCliente Cliente { get; set; } = null!;
}
