using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DC.Sofi.Domain.Inventario
{
    [Table("Articulo", Schema = "Inventario")]
    public class Articulo : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArticulo
        {
            get { return Convert.ToInt32(base.Key); }
            set { base.Key = value; }
        }

        public string Descripcion { get; set; }

        [ForeignKey("Grupo")]
        public int? GrupoId { get; set; }

        public virtual Grupo Grupo { get; set; }

        [ForeignKey("Linea")]
        public int? LineaId { get; set; }

        public virtual Linea Linea { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoProducto { get; set; }

        public virtual ICollection<Existencia> ColeccionExistencia { get; set; }

        [NotMapped]
        public string DescripcionTipoProducto
        {
            get
            {

                if (this.TipoProducto.Equals(GlobalChars.TypeProduct.Bien))
                {
                    return GlobalWords.TipoProducto.Bien;
                }
                else
                {
                    return GlobalWords.TipoProducto.Servicio;
                }
            }
        }
    }
}
