using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pagosapi.Model
{
    public class pago
    {
        [Key]
        public int id { get; set; }
        public int tipocedula { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string valor { get; set; }
    }
}
