using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Control_Horario_Arepas.Models
{
    public class Empleado
    {
        public string documentoEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string tipoEmpleado { get; set; }
        public string fechaIngreso { get; set; }
        public string contrasena { get; set; }
        public List<IngresoSalida> registroIngresoSalidas { get; set; }
    }

    public class IngresoSalida
    {
        public DateTime fechaIngreso { set; get; }
        public DateTime fechaSalida { set; get; }
    }

    public class Pedido
    {
        public string fechaPedido { set; get; }
        public string empresa { set; get; }
        public string domiciliario { set; get; }
    }
}
