using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//扁平化映射（Flattening），即当Source类中不包含Destination类中的属性的时候，AutoMapper会将Destination类中的属性进行分割，或匹配“Get”开头的方法
namespace AutoMapperDemo.Utils
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Common.Sex Sex { get; set; }
        public DateTime Birthday { get; set; }
        public PersonInfoDto Info { get; set; }
    }

    public class PersonInfoDto
    {
        public string Email { get; set; }
        public string Blog { get; set; }
        public string QQ { get; set; }
        public decimal High { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public int BirthdayYear { get; set; }
        public int BirthdayMonth { get; set; }
        public int BirthdayDay { get; set; }
        public PersonInfo Info { get; set; }
    }

    public class PersonInfo
    {
        public string Email { get; set; }
        public string Blog { get; set; }
        public string Q { get; set; }
        public decimal GetHigh() { return 100M; }
    }
}
