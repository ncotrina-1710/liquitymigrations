using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliTipoCuantia
{
    public int IdTipoCuantia { get; set; }

    public string? DescripcionTipoCuantia { get; set; }

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();
}
