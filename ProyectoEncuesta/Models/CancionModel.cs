using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEncuesta.Models
{
    public class CancionModel:ICloneable
    {
        
        public string IdCancion { get; set; }
        [Required]
        [StringLength(40)]
        public string Cancion { get; set; }
        [Required]
        public string IdGenero { get; set; }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
