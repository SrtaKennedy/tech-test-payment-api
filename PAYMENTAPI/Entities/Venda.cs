using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITESTE2.Entities
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdVendedor { get; set; }
        public string ItemVendido { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusVenda Status { get; set; }

    }
}