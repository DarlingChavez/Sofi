using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DC.Sofi.Domain.Inventario
{
    [Table("Existencia", Schema = "Inventario")]
    public class Existencia : BaseEntity
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Articulo")]
        public int IdArticulo { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("Bodega")]
        public int IdBodega { get; set; }

        public virtual Articulo Articulo { get; set; }
        public virtual Bodega Bodega { get; set; }

        /// <summary>
        /// Stock virtual
        /// </summary>
        public int CantidadVirtual { get; set; }
        public int TieneReserva { get; set; }
        public int? IdReserva { get; set; }
        /// <summary>
        /// Stock reservado
        /// </summary>
        public int CantidadReserva { get; set; }
        /// <summary>
        /// Stock Real
        /// </summary>
        public int Fisico { get; set; }
    }
}
