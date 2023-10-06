using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.DTOs;
using tarefa_2.ApplicationCore.Entities;

namespace tarefa_2.ApplicationCore.Configurations
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Estado,EstadoDTO>().ReverseMap();
            CreateMap<Cidade,CidadeDTO>().ReverseMap();
        }
    }
}
