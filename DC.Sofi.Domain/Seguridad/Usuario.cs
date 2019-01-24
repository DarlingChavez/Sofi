using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DC.Sofi.Domain.Seguridad
{
    [Table("Usuario", Schema = "Seguridad")]
    public class Usuario : BaseEntity
    {
        [Key]
        [StringLength(15)]
        public string UserName
        {
            get { return base.Key.ToString(); }
            set { base.Key = value; }
        }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(80)]
        public string Descripcion { get; set; }
        [ForeignKey("UserName")]
        public virtual ICollection<MenuByUser> MenuByUser { get; set; }
    }
}
