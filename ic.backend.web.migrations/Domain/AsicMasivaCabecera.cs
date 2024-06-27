using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public partial class AsicMasivaCabecera
{
    public int IdCabecera { get; set; }

    public int LoteId { get; set; }

    public int RegistrosTotalesCabecera { get; set; }

    public int RegistrosErroneosCabecera { get; set; }

    public string TipoDocumentoCabecera { get; set; } = null!;

    public string NombreDocumentoCabecera { get; set; } = null!;

    public int FlagAceptacion { get; set; }

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual AsicMasivaLote Lote { get; set; } = null!;
    [NotMapped]
    public int TotalRegistros { get; set; }
}
