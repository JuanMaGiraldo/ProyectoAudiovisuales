using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEncuesta.Models
{
    public class GeneroModel:ICloneable
    {
        public string IdGenero { get; set; }
        public string Genero { get; set; }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
