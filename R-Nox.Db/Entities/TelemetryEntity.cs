using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace R_Nox.Db.Entities;

public class TelemetryEntity : BaseEntity
{
    [Required]
    [Column(TypeName = "jsonb")]
    public JsonElement Telemetry { get; set; }

    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    [ForeignKey("module_id")] 
     public Guid ModuleId { get; set; }

    public virtual ModuleEntity Module { get; set; }
    
}