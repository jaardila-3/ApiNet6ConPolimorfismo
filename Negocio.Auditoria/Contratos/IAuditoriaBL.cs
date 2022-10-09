using Comun.Auditoria.DTOs;

namespace Negocio.Auditoria.Contratos
{
    public interface IAuditoriaBL
    {
        List<AuditoriaConsultaSiathDto> GenerarListadoDeConsultas(AuditoriaDto auditoria);
    }
}
