using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Auditoria.Modelo.Orm
{
    [Table("AUDITORIA_CONSULTAS_SIATH", Schema = "USR_REHU")]
    public class AuditoriaConsultaSiath
    {
        #region Propiedades
        [Key]
        [Column("ID_AUDITORIA")]
        public long IdAuditoria { get; set; }
        [Column("EMPL_UNDE_FUERZA")]
        public long EmplUndefuerza { get; set; }
        [Column("EMPL_UNDE_CONSECUTIVO")]
        public long EmplUndeConsecutivo { get; set; }
        [Column("EMPL_CONSECUTIVO")]
        public long EmplConsecutivo { get; set; }
        [Column("IDENTIFICACION_EMPLEADO")]
        public int IdentificacionEmpleado { get; set; }
        [Column("UNIDAD_EMPLEADO")]
        public string UnidadEmpleado { get; set; }
        [Column("USUARIO")]
        public string Usuario { get; set; }

        [Column("IDENTIFICACION_USUARIO")]
        public Nullable<long> IdentificacionUsuario { get; set; }

        [Column("UNIDAD_USUARIO")]
        public string UnidadUsuario { get; set; }
        [Column("MAQUINA_CONSULTA")]
        public string MaquinaConsulta { get; set; }

        [Column("FECHA_GENERACION")]
        public DateTime FechaGeneracion { get; set; }
        [Column("FORMA_CONSULTA")]
        public string FormaConsulta { get; set; }

        [Column("OBSERVACIONES")]
        public string? Observaciones { get; set; }

        #endregion


    }
}
