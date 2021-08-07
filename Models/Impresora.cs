using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeguroMundial3.Models
{
    public class Impresora
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        
        public string Marca { get; set; }
        public string Model { get; set; }
        public  int  Id_tipo { get; set; }

        public Tipo Tipo  { get; set; }

}
}
