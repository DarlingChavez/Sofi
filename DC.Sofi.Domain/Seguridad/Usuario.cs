using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DC.Sofi.Domain.Seguridad
{
    [Table("Usuario", Schema = "Seguridad")]
    public class Usuario
    {
        [Key]
        [StringLength(15)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
    }
}
