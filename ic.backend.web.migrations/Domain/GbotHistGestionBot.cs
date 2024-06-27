using System;
using System.Collections.Generic;

namespace Domain;

public partial class GbotHistGestionBot
{
    public int IdGestBot { get; set; }

    public int BotId { get; set; }

    public int ObjetoId { get; set; }

    public int TipoDocumentoId { get; set; }

    public string? NumeroDocumentoGestBot { get; set; }

    public DateTime FecGestBot { get; set; }

    public string? TipoDocumentoAuxGestBot { get; set; }

    public string? NumeroDocumentoAuxGestBot { get; set; }

    public virtual GbotBot Bot { get; set; } = null!;

    public virtual BendObjeto Objeto { get; set; } = null!;

    public virtual ApliTipoDocumento TipoDocumento { get; set; } = null!;
}
