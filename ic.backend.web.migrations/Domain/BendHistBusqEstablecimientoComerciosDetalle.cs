using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class BendHistBusqEstablecimientoComerciosDetalle
    {
        [Key]
        public int IdBendHistBusqEstablecimientoComercio { get; set; }
        public int BendHistBusqCabeceraId { get; set; }
        public BendHistBusqCabecera BendHistBusqCabecera { get; set; }
        [StringLength(250)]
        public string? NombreEstablecimiento { get; set; }
        [StringLength(250)]
        public string? DireccionEstablecimiento { get; set; }
        [StringLength(50)]
        public string? NumeroRegistroEstablecimiento { get; set; }
        public string? ObservacionEstablecimiento { get; set; }
        public int? EstadoEstablecimiento { get; set; }
        public int? UsuarioId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecActualizacion { get; set; }
    }
}
