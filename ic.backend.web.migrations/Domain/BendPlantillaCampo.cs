using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendPlantillaCampo
{
    public int IdCampo { get; set; }

    public string GrupoCampo { get; set; } = null!;

    public string NombreCampo { get; set; } = null!;

    public string DescripcionCampo { get; set; } = null!;

    public bool RequeridoCampo { get; set; }

    public string TipoDatoCampo { get; set; } = null!;

    public string TipoControlCampo { get; set; } = null!;

    public int EstadoCampo { get; set; }

    public DateTime FecCreacionCampo { get; set; }

    public int IdUsuario { get; set; }

    public virtual ICollection<BendCampoCliente> BendCampoClientes { get; set; } = new List<BendCampoCliente>();
}
