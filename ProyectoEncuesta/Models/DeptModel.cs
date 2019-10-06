using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEncuesta.Models
{
    public class DeptModel : ICloneable
    {
        public string IdDept { get; set; }
        public string Dept { get; set; }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
