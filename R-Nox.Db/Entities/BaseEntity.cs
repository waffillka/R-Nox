using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R_Nox.Db.Entities;

public class BaseEntity
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }
}