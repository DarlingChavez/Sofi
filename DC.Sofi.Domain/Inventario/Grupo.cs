using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DC.Sofi.Domain.Inventario
{
    [Table("Grupo", Schema = "Inventario")]
    public class Grupo : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGrupo
        {
            get { return Convert.ToInt32(base.Key); }
            set { base.Key = value; }
        }
        public string Descripcion { get; set; }

    }
}
