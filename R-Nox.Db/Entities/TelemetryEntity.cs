using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace R_Nox.Db.Entities;

[Table("telemetry")]
public class TelemetryEntity : BaseEntity
{
    [Required]
    [Column("telemetry", TypeName = "jsonb")]
    public JsonElement Telemetry { get; set; }

    [Column("timestamp")] 
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    [ForeignKey("module_id")] 
    [Column("module_id")] 
    public Guid ModuleId { get; set; }

    public virtual ModuleEntity Module { get; set; }
}