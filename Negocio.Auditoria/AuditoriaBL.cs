using Comun.Auditoria.DTOs;
using Datos.Auditoria.Modelo;
using Negocio.Auditoria.Contratos;
using Negocio.Auditoria.Polimorfismo;

namespace Negocio.Auditoria
{
    public class AuditoriaBL : IAuditoriaBL
    {
        private readonly ContextoDbAuditoria _context;

        public AuditoriaBL(ContextoDbAuditoria context)
        {
            _context = context;
        }

        List<AuditoriaConsultaSiathDto> auditoriaConsultaSiathDtos = new List<AuditoriaConsultaSiathDto>();
        Consulta consulta;

        public List<AuditoriaConsultaSiathDto> GenerarListadoDeConsultas(AuditoriaDto auditoria)
        {
            if (auditoria.IdentificacionConsultado != 0)
            {
                consulta = new ConsultaPorIdentificacionConsultado(auditoria.IdentificacionConsultado);
                auditoriaConsultaSiathDtos.Add(consulta.Consultar(_context));
            }

            if (auditoria.IdentificacionQuienConsulta != 0)
            {
                consulta = new ConsultaIdentificacionQuienConsulta(auditoria.IdentificacionQuienConsulta);
                auditoriaConsultaSiathDtos.Add(consulta.Consultar(_context));
            }

            if (!string.IsNullOrEmpty(auditoria.UsuarioQuienConsulta))
            {
                consulta = new ConsultaUsuarioQuienConsulta(auditoria.UsuarioQuienConsulta);
                auditoriaConsultaSiathDtos.Add(consulta.Consultar(_context));
            }            

            return auditoriaConsultaSiathDtos;
        }
    }
}
