using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapperDemo.Utils;

namespace AutoMapperDemo
{
    public class Simple
    {
        static void Main1(string[] args)
        //static void Main(string[] args)
        {
            //Mapper.Initialize(cfg =>
            //    {
            //        cfg.CreateMap<PersonInfo, PersonInfoDto>()
            //            .ForMember(d => d.QQ, s => s.MapFrom(src => src.Q));
            //        cfg.CreateMap<Person, PersonDto>()
            //            .ForMember(d => d.Birthday,
            //                s => s.MapFrom(src => new DateTime(src.BirthdayYear, src.BirthdayMonth, src.BirthdayDay)));
            //    }
            //);
            //Global.asax
            AutoMapperDemo.AutoMapper.Configuration.Configure();
            Person Po = new Person
            {
                Id = 1,
                Name = "McXmart",
                Sex = 0,
                BirthdayYear = 2016,
                BirthdayMonth = 10,
                BirthdayDay = 1,
                Info = new PersonInfo() { 
                    Email = "111@qq.com",
                    Blog = "111",
                    Q = "123456"
                }
            };
            PersonDto Dto = Mapper.Map<Person, PersonDto>(Po);
            Console.WriteLine(
                "转换成功：转换记录的ID为{0}，Name为{1}，Sex为{2}，Birthday为{3}；\n\t Info的Email为{4},Blog为{5}，QQ为{6}，High为{7}。", 
                Dto.Id, 
                Dto.Name, 
                Dto.Sex.ToString(), 
                Dto.Birthday.ToString("yyyy-MM-dd"),
                Dto.Info.Email,
                Dto.Info.Blog,
                Dto.Info.QQ,
                Dto.Info.High
            );
            Console.ReadKey();
        }
    }
}
