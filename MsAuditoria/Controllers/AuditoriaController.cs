using Comun.Auditoria.DTOs;
using Microsoft.AspNetCore.Mvc;
using Negocio.Auditoria.Contratos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MsAuditoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditoriaController : ControllerBase
    {
        private readonly IAuditoriaBL _auditoriaBL;

        public AuditoriaController(IAuditoriaBL auditoriaBL)
        {
            _auditoriaBL = auditoriaBL;
        }


        // GET: api/<AuditoriaController>
        [HttpGet]
        public IEnumerable<AuditoriaConsultaSiathDto> Get([FromQuery] AuditoriaDto auditoriaDto)
        {
            return _auditoriaBL.GenerarListadoDeConsultas(auditoriaDto);
        }

        
    }
}
