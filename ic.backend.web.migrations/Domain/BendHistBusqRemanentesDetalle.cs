using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BendHistBusqRemanentesDetalle
    {
        public int IdBendHistBusqRemanentes { get; set; }
        public int BendHistBusqCabeceraId { get; set; }
        public BendHistBusqCabecera BendHistBusqCabecera { get; set; }
        public bool? TieneRemanente { get; set; }
        public int? EstadoRemanente { get; set; }
        public string? Observacion { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime? FecCreacion { get; set; }
        public DateTime? FecActualizacion { get; set; }
    }
}
