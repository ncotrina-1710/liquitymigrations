using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliFecha
{
    public int IdFecha { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Annio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }
}
