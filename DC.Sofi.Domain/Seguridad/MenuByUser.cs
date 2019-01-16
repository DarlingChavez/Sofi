using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DC.Sofi.Domain.Seguridad
{
    [Table("MenuByUser", Schema = "Seguridad")]
    public class MenuByUser : BaseEntity
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Usuario")]
        public string UserName { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("Menu")]
        public int IdMenu { get; set; }
        [Required]
        public bool Insert { get; set; }
        [Required]
        public bool Update { get; set; }
        [Required]
        public bool Destroy { get; set; }
        public string Permisos { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
