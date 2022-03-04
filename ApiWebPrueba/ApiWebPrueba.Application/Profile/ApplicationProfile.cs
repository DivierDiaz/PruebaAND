using ApiWebPrueba.Application.DTO;
using ApiWebPrueba.Domain.Personas.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWebPrueba.Application.Profile
{
    public class ApplicationProfile :AutoMapper.Profile 
    {
        public ApplicationProfile()
        {
            CreateMap<PersonasDTO, PersonasEntity>().ReverseMap();
        }
    }
}
