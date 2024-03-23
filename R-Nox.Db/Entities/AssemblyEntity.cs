using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R_Nox.Db.Entities;

public class AssemblyEntity : BaseEntity
{
    [Required]
    [Column("name")]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(500)]
    public string Description { get; set; }
    
    public virtual ICollection<ModuleEntity>? Modules { get; set; }
}