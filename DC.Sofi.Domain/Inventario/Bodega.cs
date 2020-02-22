using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DC.Sofi.Domain.Inventario
{
    [Table("Bodega", Schema = "Inventario")]
    public class Bodega : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBodega
        {
            get { return Convert.ToInt32(base.Key); }
            set { base.Key = value; }
        }

        public string Descripcion { get; set; }

        public bool TieneReserva { get; set; }
        public bool EsRerserva { get; set; }

        public int? IdReserva { get; set; }
        [ForeignKey("IdReserva")]
        public Bodega BodegaReserva { get; set; }
    }
}
