using Datos.Auditoria.Modelo.Orm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Auditoria.Modelo
{
    public class ContextoDbAuditoria : DbContext
    {
        #region constructores
        public ContextoDbAuditoria(DbContextOptions _options) : base(_options)
        {

        }
        #endregion

        #region MyRegion
        public DbSet<AuditoriaConsultaSiath> AuditoriaConsultaSiath { get; set; }
        #endregion

    }
}
