using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffSesionesActiva
{
    public int UsuarioId { get; set; }

    public int ValidacionId { get; set; }

    public string CodigoVerifSesion { get; set; } = null!;

    public DateTime FecCodigoVerifSesion { get; set; }

    public DateTime FecInicioSesion { get; set; }

    public int FlagExitoSesion { get; set; }

    public virtual BoffUsuario Usuario { get; set; } = null!;

    public virtual BendValidacione Validacion { get; set; } = null!;
}
