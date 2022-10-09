using Comun.Auditoria.DTOs;
using Comun.Auditoria.Mapping;
using Datos.Auditoria.Modelo;

namespace Negocio.Auditoria.Polimorfismo
{
    public class ConsultaPorIdentificacionConsultado : Consulta
    {
        private readonly long id;

        public ConsultaPorIdentificacionConsultado(long id)
        {
            this.id = id;
        }

        public override AuditoriaConsultaSiathDto Consultar(ContextoDbAuditoria context)
        {
            var registro = context.AuditoriaConsultaSiath.FirstOrDefault(x => x.IdentificacionEmpleado == id);

            if (registro == null)
                return new AuditoriaConsultaSiathDto();

            var dto = registro.MapTo<AuditoriaConsultaSiathDto>();
            return dto;
        }
    }
}
