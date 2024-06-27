using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public partial class ApliTipoEvento
{
    public int IdTipoEvento { get; set; }

    public string DescripcionTipoEvento { get; set; } = null!;

    public DateTime FecCreacionTipoEvento { get; set; }

    public virtual ICollection<ApliEvento> ApliEventos { get; set; } = new List<ApliEvento>();
    [NotMapped]
    public int TotalRegistros { get; set; }
}
