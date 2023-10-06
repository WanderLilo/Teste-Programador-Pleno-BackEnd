using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_3.ApplicationCore.DTOs;
using tarefa_3.ApplicationCore.Entities;

namespace tarefa_3.ApplicationCore.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Pessoa, PessoaDTO>().ReverseMap();

            //CreateMap<Estado, EstadoDTO>().ReverseMap();
            //CreateMap<Cidade, CidadeDTO>().ReverseMap();
        }
    }

}
