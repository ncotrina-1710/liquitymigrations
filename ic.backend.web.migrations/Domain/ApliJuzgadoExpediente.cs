using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliJuzgadoExpediente
{
    public int IdJuzgadoExpediente { get; set; }

    public int JuzgadoId { get; set; }

    public int ExpedienteId { get; set; }

    public string? JuzgadoOrigen { get; set; }

    public string? CiudadJuzgadoExpediente { get; set; }

    public string? DepartamentoJuzgadoExpediente { get; set; }

    public string? AbogadoInicialJuzgadoExpediente { get; set; }

    public DateTime FecCreacionJuzgadoExpediente { get; set; }

    public DateTime? FecActualizacionjuzgadoExpediente { get; set; }

    public int? UsuarioId { get; set; }

    public virtual AsicExpediente Expediente { get; set; } = null!;

    public virtual ApliJuzgado Juzgado { get; set; } = null!;
}
