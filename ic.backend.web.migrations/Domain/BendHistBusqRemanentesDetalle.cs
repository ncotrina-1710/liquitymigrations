﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class BendHistBusqRemanentesDetalle
    {
        [Key]
        public int IdBendHistBusqRemanente { get; set; }
        public int BendHistBusqCabeceraId { get; set; }
        public BendHistBusqCabecera BendHistBusqCabecera { get; set; }
        public bool? TieneRemanente { get; set; }
        public int? EstadoRemanente { get; set; }
        public string? ObservacionRemanente { get; set; }
        public int? UsuarioId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecActualizacion { get; set; }
    }
}
