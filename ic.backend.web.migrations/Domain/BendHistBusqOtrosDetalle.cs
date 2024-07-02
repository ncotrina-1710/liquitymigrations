using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class BendHistBusqOtrosDetalle
    {
        [Key]
        public int IdBendHistBusqOtro { get; set; }
        public int BendHistBusqCabeceraId { get; set; }
        public BendHistBusqCabecera BendHistBusqCabecera { get; set; }
        public bool? TieneOtros { get; set; }
        public int? EstadoOtros { get; set; }
        public string? ObservacionOtros { get; set; }
        public int? UsuarioId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecActualizacion { get; set; }
    }
}
