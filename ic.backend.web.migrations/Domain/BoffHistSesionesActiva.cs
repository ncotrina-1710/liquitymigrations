using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffHistSesionesActiva
{
    public int IdHistSesionActiva { get; set; }

    public int SesionActivaUsuarioId { get; set; }

    public DateTime FecInicioHistSesion { get; set; }

    public DateTime FecfinHistSesion { get; set; }
}
