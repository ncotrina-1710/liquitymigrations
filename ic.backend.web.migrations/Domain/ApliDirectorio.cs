using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliDirectorio
{
    public int IdDirectorio { get; set; }

    public string TipoDirectorio { get; set; } = null!;

    public int EstadoDirectorio { get; set; }

    public string TelefonoDirectorio { get; set; } = null!;

    public string EmailDirectorio { get; set; } = null!;

    public string IdentificacionDirectorio { get; set; } = null!;

    public string? WhatsAppDirectorio { get; set; }

    public int ClienteId { get; set; }

    public DateTime FecCreacionDirectorio { get; set; }

    public DateTime FecActualizacionDirectorio { get; set; }

    public int IdUsuario { get; set; }

    public virtual BoffCliente Cliente { get; set; } = null!;
}
