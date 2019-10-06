using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEncuesta.Models
{
    public class PreguntaModel : ICloneable
    {
        public string IdPregunta { get; set; }
        public string IdPreguntaPrincipal { get; set; }
        public string Enunciado { get; set; }

        public string IdTipo { get; set; }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
