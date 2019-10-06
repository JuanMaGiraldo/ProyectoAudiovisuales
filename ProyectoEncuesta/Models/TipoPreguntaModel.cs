using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEncuesta.Models
{
    public class TipoPreguntaModel : ICloneable
    {
        public string IdTipo { get; set; }
        public string Tipo { get; set; }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
