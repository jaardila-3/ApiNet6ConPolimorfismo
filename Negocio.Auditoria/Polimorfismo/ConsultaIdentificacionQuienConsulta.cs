using Comun.Auditoria.DTOs;
using Comun.Auditoria.Mapping;
using Datos.Auditoria.Modelo;

namespace Negocio.Auditoria.Polimorfismo
{
    public class ConsultaIdentificacionQuienConsulta : Consulta
    {
        private readonly long id;

        public ConsultaIdentificacionQuienConsulta(long id)
        {
            this.id = id;
        }

        public override AuditoriaConsultaSiathDto Consultar(ContextoDbAuditoria context)
        {
            var registro = context.AuditoriaConsultaSiath.FirstOrDefault(x => x.IdentificacionUsuario == id);

            if (registro == null)
                return new AuditoriaConsultaSiathDto();

            var dto = registro.MapTo<AuditoriaConsultaSiathDto>();
            return dto;
        }
    }
}
