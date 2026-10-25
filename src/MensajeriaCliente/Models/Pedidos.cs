using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensajeriaCliente.Models
{
    public class Pedidos
    {
        public int ID_PEDIDO { get; set; }
        public string ESTADO_ENTREGA { get; set; }
        public DateTime FECHA_CREACION { get; set; }
        public string DESTINATARIO { get; set; }
        public string DIRECCION { get; set; }
        public string CODIGO_POSTAL { get; set; }
        public string TELEFONO { get; set; }
        public int ID_MENSAJERO { get; set; }
    }
}