using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmitMapper;
using EmitMapper.MappingConfiguration;
using EmitMapperDemo.Utils;

///http://emitmapper.codeplex.com/
namespace EmitMapperDemo
{
    public class Simple
    {
        //static void Main1(string[] args)
        static void Main(string[] args)
        {
            //简单的转换
            var mapper = ObjectMapperManager.DefaultInstance.GetMapper<SourceA, desB>(
                new DefaultMapConfig()
                //属性指定
                .MatchMembers((x, y) =>
                    {
                        if (x == "dt" && y == "dateTime")
                        {
                            return true;
                        }
                        return x == y;
                    }
                )
                //属性转换
                .PostProcess<desB>((value, state) =>
                {
                    value.stra = "这是字符串：" + value.stra;
                    value.JsonStr = @"{'stra':'" + value.stra + "','dateTime':'" + value.dateTime + "'}";
                    return value;
                })
                //属性忽略
                .IgnoreMembers<SourceA, desB>(new string[] { "name" })
                //属性null时的默认值
                .NullSubstitution<DateTime?, DateTime>((value) => DateTime.Now)
            );
            var a = new SourceA
            {
                dt = DateTime.Now,
                inta = 1,
                stra = "3",
                dt2 = DateTime.Now.AddDays(1),
                name = "McXmart",
                address = null
            };
            var b = mapper.Map(a);
            if (b != null)
            {
                Console.WriteLine("b.DateTime:" + b.dateTime);
                Console.WriteLine("b.int:" + b.inta);
                Console.WriteLine("b.stra:" + b.stra);
                Console.WriteLine("b.JsonStr :" + b.JsonStr);
                Console.WriteLine("b.name :" + b.name);
                Console.WriteLine("b.address :" + b.address);
            }
            Console.ReadKey();
        }
    }
}
