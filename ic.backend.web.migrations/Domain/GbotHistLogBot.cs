using System;
using System.Collections.Generic;

namespace Domain;

public partial class GbotHistLogBot
{
    public int IdLogBot { get; set; }

    public int BotId { get; set; }

    public int LogEventoId { get; set; }

    public int LogCategoriaId { get; set; }

    public int LogInteraccionId { get; set; }

    public int LogFuenteId { get; set; }

    public DateTime FecLogBot { get; set; }

    public int TipoDocumentoId { get; set; }

    public string? NumeroDocumentoLogBot { get; set; }

    public string? TipoDocumentoAuxLogBot { get; set; }

    public string? NumeroDocumentoAuxLogBot { get; set; }

    public string? Mensaje { get; set; }

    public int? FlagBarrido { get; set; }

    public virtual GbotBot Bot { get; set; } = null!;

    public virtual GbotLogCategoria LogCategoria { get; set; } = null!;

    public virtual GbotLogEvento LogEvento { get; set; } = null!;

    public virtual GbotLogInteraccione LogInteraccion { get; set; } = null!;

    public virtual ApliTipoDocumento TipoDocumento { get; set; } = null!;
}
