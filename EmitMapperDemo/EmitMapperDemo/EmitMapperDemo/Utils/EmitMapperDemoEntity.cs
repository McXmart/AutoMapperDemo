using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitMapperDemo.Utils
{
    public class SourceA
    {
        public int inta { get; set; }
        public DateTime dt { get; set; }
        public string stra { get; set; }
        public DateTime dt2 { get; set; }
        public string name { get; set; }
        public DateTime? address { get; set; }
    }

    public class desB
    {
        public int inta { get; set; }
        public DateTime dateTime { get; set; }
        public string stra { get; set; }
        public string JsonStr { get; set; }
        public string name { get; set; }
        public DateTime address { get; set; }
    }
}
