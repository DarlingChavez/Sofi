using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace DC.Sofi.Domain.Inventario
{
    [Table("Linea", Schema = "Inventario")]
    public class Linea: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLinea 
        { 
            get { return Convert.ToInt32(base.Key); }
            set { base.Key = value; }
        }
        [Required]
        [StringLength(6)]
        public string Descripcion { get; set; }
        public bool TienePadre { get; set; }
        
        public int? PadreId { get; set; }
        [ForeignKey("PadreId")]
        public virtual Linea Padre { get; set; }

        public virtual ICollection<Linea> Hijos { get; set; }
    }
}
