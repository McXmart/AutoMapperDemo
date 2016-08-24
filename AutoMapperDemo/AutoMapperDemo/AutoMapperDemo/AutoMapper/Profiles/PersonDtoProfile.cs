using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapperDemo.Utils;

namespace AutoMapperDemo.AutoMapper.Profiles
{
    public class PersonDtoProfile:Profile
    {
        protected override void Configure()
        {
            CreateMap<Person, PersonDto>()
                .ForMember(d => d.Birthday,
                    s => s.MapFrom(src => new DateTime(src.BirthdayYear,src.BirthdayMonth ,src.BirthdayDay)))
                .ForMember(d => d.Sex, s => s.MapFrom(src => (Common.Sex)src.Sex));
        }
    }
}
