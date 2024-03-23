using System.ComponentModel.DataAnnotations.Schema;

namespace R_Nox.Db.Entities;

public class ModuleEntity : BaseEntity
{
    [ForeignKey("assembly_id")]
    public Guid AssemblyId { get; set; }
    
    public string Type { get; set; }
    
    public virtual AssemblyEntity Assembly { get; set; }
    public virtual ICollection<TelemetryEntity>? Telemetry { get; set; }
}