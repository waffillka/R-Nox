using System.ComponentModel.DataAnnotations.Schema;
using R_Nox.Domain.Enums;
using R_Nox.Domain.Exceptions;

namespace R_Nox.Db.Entities;

[Table("module")]
public class ModuleEntity : BaseEntity
{
    [ForeignKey("assembly_id")]
    public Guid AssemblyId { get; set; }
    
    [Column("type")] 
    public ModuleType Type { get; set; }
    
    public virtual AssemblyEntity Assembly { get; set; }
    public virtual ICollection<TelemetryEntity>? Telemetry { get; set; }
}