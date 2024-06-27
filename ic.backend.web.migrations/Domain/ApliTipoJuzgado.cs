using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliTipoJuzgado
{
    public int IdTipoJuzgado { get; set; }

    public string DescripcionTipoJuzgado { get; set; } = null!;

    public DateTime FecCreacionTipoJuzgado { get; set; }

    public int? UsuarioId { get; set; }

    public virtual ICollection<ApliSubtipoJuzgado> ApliSubtipoJuzgados { get; set; } = new List<ApliSubtipoJuzgado>();
}
