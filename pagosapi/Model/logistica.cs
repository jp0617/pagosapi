using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pagosapi.Model
{
    public class logistica
    {
        [Key]
        public int id { get; set; }
        public int id_pago { get; set; }
    }
}
