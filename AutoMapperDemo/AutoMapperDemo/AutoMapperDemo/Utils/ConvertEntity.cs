using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperDemo.Utils
{
    public class Source
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public string Value3 { get; set; }
    }

    public class Destination
    {
        public int Total { get; set; }
        public int Value3 { get; set; }
    }
}
