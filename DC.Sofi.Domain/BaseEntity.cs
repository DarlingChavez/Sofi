using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DC.Sofi.Domain
{
    public abstract class BaseEntity
    {
        [NotMapped]
        public object Key { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [NotMapped]
        public string Estado
        {
            get
            {
                string estado = string.Empty;
                switch (this.Status)
                {
                    case GlobalChars.Status.Activo:
                        estado = GlobalWords.Estado.Activo;
                        break;
                    case GlobalChars.Status.Inactivo:
                        estado = GlobalWords.Estado.Inactivo;
                        break;
                }
                return estado;
            }
        }

    }
}
