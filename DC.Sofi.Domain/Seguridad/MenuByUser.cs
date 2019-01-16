using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DC.Sofi.Domain.Seguridad
{
    [Table("MenuByUser", Schema = "Seguridad")]
    public class MenuByUser
    {
        [Key]
        [ForeignKey("Usuario")]
        public string UserName { get; set; }
        [Key]
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
