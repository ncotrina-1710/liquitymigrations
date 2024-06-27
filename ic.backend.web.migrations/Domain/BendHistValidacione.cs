using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendHistValidacione
{
    public int IdHistValidacion { get; set; }

    public int UsuarioId { get; set; }

    public int ValidacionId { get; set; }

    public int LocacionId { get; set; }

    public string TelefonoHistValidacion { get; set; } = null!;

    public string EmailHistValidacion { get; set; } = null!;

    public string CodigoVerifHistValidacion { get; set; } = null!;

    public DateTime FecCodigoVerifHistValidacion { get; set; }

    public DateTime FecInicioSesionHistValidacion { get; set; }

    public int FlagExitoSesionHistValidacion { get; set; }

    public virtual ApliLocacione Locacion { get; set; } = null!;

    public virtual BoffUsuario Usuario { get; set; } = null!;

    public virtual BendValidacione Validacion { get; set; } = null!;
}
