using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliSubtipoJuzgado
{
    public int IdSubtipoJuzgado { get; set; }

    public int TipoJuzgadoId { get; set; }

    public string DescripcionSubtipoJuzgado { get; set; } = null!;

    public DateTime FecCreacionSubtipoJuzgado { get; set; }

    public int? UsuarioId { get; set; }

    public virtual ICollection<ApliLocacionJuzgado> ApliLocacionJuzgados { get; set; } = new List<ApliLocacionJuzgado>();

    public virtual ApliTipoJuzgado TipoJuzgado { get; set; } = null!;
}
