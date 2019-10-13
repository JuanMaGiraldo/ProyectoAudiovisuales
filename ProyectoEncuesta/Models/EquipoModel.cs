using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEncuesta.Models
{
    public class EquipoModel:ICloneable
    {
        public string IdEquipo { get; set; }
        public string Equipo { get; set; }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
