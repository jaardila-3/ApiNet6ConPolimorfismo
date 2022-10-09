using Comun.Auditoria.DTOs;
using Comun.Auditoria.Mapping;
using Datos.Auditoria.Modelo;

namespace Negocio.Auditoria.Polimorfismo
{
    public class ConsultaUsuarioQuienConsulta : Consulta
    {
        private readonly string usuario;

        public ConsultaUsuarioQuienConsulta(string usuario)
        {
            this.usuario = usuario;
        }

        public override AuditoriaConsultaSiathDto Consultar(ContextoDbAuditoria context)
        {
            var registro = context.AuditoriaConsultaSiath.FirstOrDefault(x => x.Usuario == usuario);

            if (registro == null)
                return new AuditoriaConsultaSiathDto();

            var dto = registro.MapTo<AuditoriaConsultaSiathDto>();
            return dto;
        }
    }
}
