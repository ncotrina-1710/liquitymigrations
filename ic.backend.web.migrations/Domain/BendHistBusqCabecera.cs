using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class BendHistBusqCabecera
    {
        [Key]
        public int IdBendHistBusqCabecera { get; set; }
        public int TipoMedidaCautelarId { get; set; }
        public BoffTipoMedidasCautelare TipoMedidaCautelar { get; set; }
        public int DeudorId { get; set; }
        public BendDeudore Deudor { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime? FecCreacion { get; set; }
        public DateTime? FecActualizacion { get; set; }
    }
}
