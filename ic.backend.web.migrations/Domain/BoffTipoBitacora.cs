using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffTipoBitacora
{
    public int IdTipoBitacora { get; set; }

    public string CodigoBitacora { get; set; } = null!;

    public string NombreBitacora { get; set; } = null!;

    public int EstadoBitacora { get; set; }

    public bool? ControlWeb { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FecCreacionBitacora { get; set; }

    public DateTime? FecActualizacionBitacora { get; set; }
}
