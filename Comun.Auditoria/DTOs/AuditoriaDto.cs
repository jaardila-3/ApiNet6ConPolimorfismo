using System.ComponentModel.DataAnnotations;

namespace Comun.Auditoria.DTOs
{
    public class AuditoriaDto
    {
        [Range(0, 10000000000)]
        public long IdentificacionConsultado { get; set; }
        [Range(0, 10000000000)]
        public long IdentificacionQuienConsulta { get; set; }
        [StringLength(30, MinimumLength = 0)]
        public string UsuarioQuienConsulta { get; set; } = string.Empty;
    }
}
