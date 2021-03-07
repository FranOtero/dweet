using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomateApp.Mensajes
{
    public record MedidaHumedad
    {
        public DateTime Hora { get; set; }
        public int Humedad { get; set; }
    }
}
