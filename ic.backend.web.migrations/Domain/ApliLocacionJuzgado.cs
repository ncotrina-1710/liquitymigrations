using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliLocacionJuzgado
{
    public int IdLocacionJuzgado { get; set; }

    public int? SubtipoJuzgadoId { get; set; }

    public string CiudadJuzgados { get; set; } = null!;

    public string DepartamentoJuzgado { get; set; } = null!;

    public string? ZonaJuzgado { get; set; }

    public int? UsuarioId { get; set; }

    public virtual ICollection<ApliJuzgado> ApliJuzgados { get; set; } = new List<ApliJuzgado>();

    public virtual ApliSubtipoJuzgado? SubtipoJuzgado { get; set; }
}
