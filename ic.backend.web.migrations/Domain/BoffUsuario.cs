using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public partial class BoffUsuario
{
    private const int USUARIO_ESTADO_BLOQUEADO = -1;
    private const int USUARIO_ESTADO_CONTRASENA_EXPIRADO = 1;
    public int IdUsuario { get; set; }

    public int RolId { get; set; }

    public int ClienteId { get; set; }

    public int RespuestaId { get; set; }

    public DateTime FecAltaUsuario { get; set; }

    public int EstadoUsuario { get; set; }

    public string DescripcionEstadoUsuario { get; set; } = null!;

    public string LoginUsuario { get; set; } = null!;

    public string ContrasenaUsuario { get; set; } = null!;

    public string NombresUsuario { get; set; } = null!;

    public string ApellidosUsuario { get; set; } = null!;

    public string EmailUsuario { get; set; } = null!;

    public string TelefonoUsuario { get; set; } = null!;

    public int EstadoContrasenaUsuario { get; set; }

    public DateTime FecFinContrasenaUsuario { get; set; }

    public DateTime? FecBajaUsuario { get; set; }

    public bool VerificarCorreo { get; set; }

    public int TipoDocumentoId { get; set; }

    public string NumeroDocumentoUsuario { get; set; } = null!;

    public virtual ICollection<ApliAbogado> ApliAbogados { get; set; } = new List<ApliAbogado>();

    public virtual ICollection<ApliAsignacione> ApliAsignaciones { get; set; } = new List<ApliAsignacione>();

    public virtual ICollection<ApliDetalleExpedienteEvento> ApliDetalleExpedienteEventos { get; set; } = new List<ApliDetalleExpedienteEvento>();

    public virtual ICollection<ApliEstatusProceso> ApliEstatusProcesos { get; set; } = new List<ApliEstatusProceso>();

    public virtual ICollection<BendHistValidacione> BendHistValidaciones { get; set; } = new List<BendHistValidacione>();

    public virtual BendUsuario? BendUsuario { get; set; }

    public virtual ICollection<BoffEstadoProcesalDocumento> BoffEstadoProcesalDocumentos { get; set; } = new List<BoffEstadoProcesalDocumento>();

    public virtual ICollection<BoffHistContrasena> BoffHistContrasenas { get; set; } = new List<BoffHistContrasena>();

    public virtual ICollection<BoffPerfilRole> BoffPerfilRoles { get; set; } = new List<BoffPerfilRole>();

    public virtual ICollection<BoffUsuarioCuenta> BoffUsuarioCuenta { get; set; } = new List<BoffUsuarioCuenta>();

    public virtual BoffCliente Cliente { get; set; } = null!;

    public virtual BendRespuestaSesione Respuesta { get; set; } = null!;

    public virtual BoffRole Rol { get; set; } = null!;

    public virtual ApliTipoDocumento TipoDocumento { get; set; } = null!;
    [NotMapped]
    public int TotalRegistros { get; set; }
    [NotMapped]
    public int UsuarioIdCreador { get; set; }

    public string ValidarLoginEstadoYContrasena()
    {
        if (EstadoUsuario == USUARIO_ESTADO_BLOQUEADO)
            return $"El usuario {LoginUsuario} está bloqueado temporalmente.";

        if (FecFinContrasenaUsuario <= DateTime.Now ||
            EstadoContrasenaUsuario == USUARIO_ESTADO_CONTRASENA_EXPIRADO)
            return "La contraseña a expirado, por favor proceder a cambiar la contraseña.";

        return string.Empty;
    }
}
