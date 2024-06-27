using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffHistSesionesErronea
{
    public int IdHistSesionErronea { get; set; }

    public int SesionErroneaUsuarioId { get; set; }

    public DateTime FecInicioHistSesion { get; set; }

    public DateTime FecfinHistSesion { get; set; }
}
