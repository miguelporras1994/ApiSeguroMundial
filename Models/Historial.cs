
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeguroMundial3.Models
{
    public class Historial
    {
       public int   Id { get; set; }
        public string  Title_Matenimiento { get; set; }
        public string    Descripcion_Matenimiento { get; set; }
        public Area Idarea { get; set; }
        public Impresora Id_impresora { get; set; }
        public  Tecnico Id_Tecnico { get; set; }


    }
}
