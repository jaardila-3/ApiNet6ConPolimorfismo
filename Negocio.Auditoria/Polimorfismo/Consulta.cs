using Comun.Auditoria.DTOs;
using Datos.Auditoria.Modelo;

namespace Negocio.Auditoria.Polimorfismo
{
    public abstract class Consulta
    {
        public abstract AuditoriaConsultaSiathDto Consultar(ContextoDbAuditoria context);
    }
}
