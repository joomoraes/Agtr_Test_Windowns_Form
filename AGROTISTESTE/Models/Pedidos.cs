using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTISTESTE.Models
{
    public class Pedidos
    {
        public string Codigo { get; set; }
        public DateTime dataemissao { get; set; }
        public int codigocliente { get; set; }
        public string nomecliente { get; set; }
        public double precototalpedido { get; set; }
        public double pesototalpedido { get; set; }
    }
}
