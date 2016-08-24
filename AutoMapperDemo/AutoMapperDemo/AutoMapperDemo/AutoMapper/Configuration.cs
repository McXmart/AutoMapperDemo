using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

namespace AutoMapperDemo.AutoMapper
{
    public class Configuration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<Profiles.PersonDtoProfile>();
                cfg.AddProfile<Profiles.PersonInfoDtoProfile>();
            });
        }
    }
}
