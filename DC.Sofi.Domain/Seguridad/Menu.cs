using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DC.Sofi.Domain.Seguridad
{
    [Table("Menu", Schema = "Seguridad")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMenu { get; set; }
        [Required]
        public int IdMenuPadre { get; set; }
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        public bool TieneFormulario { get; set; }
        [StringLength(50)]
        public string NombreFormulario { get; set; }
        [StringLength(150)]
        public string NombreAsembly { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
    }
}
