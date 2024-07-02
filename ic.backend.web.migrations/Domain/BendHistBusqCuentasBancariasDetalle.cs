using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class BendHistBusqCuentasBancariasDetalle
    {
        [Key]
        public int IdBendHistBusqCuentasBancarias { get; set; }
        public int BendHistBusqCabeceraId { get; set; }
        public BendHistBusqCabecera BendHistBusqCabecera { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? MontoEmbargadoCuentasBancarias { get; set; }
        public string? ObservacionCuentasBancarias { get; set; }
        public int? EstadoCuentasBancarias { get; set; }
        public int? UsuarioId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FecCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecActualizacion { get; set; }
    }
}
