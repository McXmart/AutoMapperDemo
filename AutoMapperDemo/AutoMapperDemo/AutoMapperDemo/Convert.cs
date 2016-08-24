using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapperDemo.Utils;

namespace AutoMapperDemo
{
    public class Convert
    {
       static void Main(string[] args)
        //static void Main2(string[] args)
        {
            #region 自定义值转换
            Mapper.Initialize(cfg =>
                cfg.CreateMap<Source, Destination>()
                    //.ForMember(d => d.Total, s => s.ResolveUsing<CustomResolver>())
                    //.ForMember(d => d.Value3, opt => opt.Ignore())//属性忽略
                    //.ForMember(d => d.Value3, opt => opt.UseValue<int>(800))//属性填充固定值
            );
            Source src = new Source()
            {
                Value1 = 1,
                Value2 = 2,
                Value3 = "3"
            };
            Destination dest = Mapper.Map<Destination>(src);
            Console.WriteLine(
                "转换成功：转换记录的Total为{0}。",
                dest.Total
            );
            Console.ReadKey();
            #endregion

            Console.WriteLine("=======");

            #region 自定义类型转换器
            Mapper.Initialize(cfg =>
                cfg.CreateMap<Source, Destination>()
                    .ConvertUsing<TypeConverter>()
            );
            Source src2 = new Source()
            {
                Value1 = 1,
                Value2 = 2,
                Value3 = "3"
            };
            Destination dest2 = Mapper.Map<Destination>(src2);
            Console.WriteLine(
                "转换成功：转换记录的Value3为{0}。",
                dest2.Value3
            );
            Console.ReadKey();
            #endregion
        }

        public class CustomResolver : ValueResolver<Source, int>
        {
            protected override int ResolveCore(Source source)
            {
                return source.Value1 + source.Value2;
            }
        }

        public class TypeConverter : TypeConverter<Source, Destination>
        {
            protected override Destination ConvertCore(Source source)
            {
                Destination dest = new Destination();
                dest.Value3 = System.Convert.ToInt32(source.Value3) + 1;
                return dest;
            }
        }
    }
}
