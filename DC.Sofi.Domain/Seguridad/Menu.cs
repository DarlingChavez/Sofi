using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DC.Sofi.Domain.Seguridad
{
    [Table("Menu", Schema = "Seguridad")]
    public class Menu : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMenu
        {
            get { return Convert.ToInt32(base.Key); }
            set { base.Key = value; }
        }
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

        [ForeignKey("IdMenu")]
        public virtual ICollection<MenuByUser> MenuByUser { get; set; }

    }
}
