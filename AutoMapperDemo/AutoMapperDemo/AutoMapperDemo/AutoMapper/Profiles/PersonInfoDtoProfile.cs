using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapperDemo.Utils;

namespace AutoMapperDemo.AutoMapper.Profiles
{
    public class PersonInfoDtoProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<PersonInfo, PersonInfoDto>()
                 .ForMember(d => d.QQ, s => s.MapFrom(src => src.Q));
        }
    }
}
