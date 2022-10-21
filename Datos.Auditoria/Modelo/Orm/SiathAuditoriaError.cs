using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Auditoria.Modelo.Orm
{
    /// <summary>
    /// tabla para las auditorias del sistema siathweb 4.0
    /// </summary>
    [Table("SIATH_AUDITORIA_ERROR", Schema = "xxxxxx")]
    public class SiathAuditoriaError
    {
        #region Propiedades
        [Key]
        [Column("ID_AUDITORIA_ERROR")]
        public long IdAuditoriaError { get; set; }
        [Column("NOMBRE_MICROSERVICIO")]
        public string NombreMicroservicio { get; set; }
        [Column("MENSAJE_ERROR")]
        public string MensajeError { get; set; }
        [Column("IDENTIFICACION_LOGUEADO")]
        public long Identificacionlogueado { get; set; }
        [Column("FECHA_ERROR")]
        public DateTime FechaError { get; set; }

        #endregion

    }
}
