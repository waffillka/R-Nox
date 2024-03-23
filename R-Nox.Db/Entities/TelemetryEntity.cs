using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace R_Nox.Db.Entities;

public class TelemetryEntity : BaseEntity, IDisposable
{
    [Required]
    [Column(TypeName = "jsonb")]
    public JsonDocument Telemetry { get; set; }

    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    [ForeignKey("module_id")] 
     public Guid ModuleId { get; set; }

    public virtual ModuleEntity Module { get; set; }

    public void Dispose() => Telemetry?.Dispose();
}