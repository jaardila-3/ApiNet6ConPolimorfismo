namespace Comun.Auditoria.DTOs
{
    public class AuditoriaConsultaSiathDto
    {
        #region Propiedades
        public long IdAuditoria { get; set; }
        public long EmplUndefuerza { get; set; }
        public long EmplUndeConsecutivo { get; set; }
        public long EmplConsecutivo { get; set; }
        public int IdentificacionEmpleado { get; set; }
        public string UnidadEmpleado { get; set; }
        public string Usuario { get; set; }
        public Nullable<long> IdentificacionUsuario { get; set; }
        public string UnidadUsuario { get; set; }
        public string MaquinaConsulta { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public string FormaConsulta { get; set; }
        public string? Observaciones { get; set; }

        #endregion

    }
}
