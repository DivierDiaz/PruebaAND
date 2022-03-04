using ApiWebPrueba.Application.DTO;
using ApiWebPrueba.Application.Models;
using ApiWebPrueba.Application.Profile;
using ApiWebPrueba.Application.UseCases.Interface;
using ApiWebPrueba.Domain.Personas.Services;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using System;
using System.Collections.Generic;
using System.Text;
using ApiWebPrueba.Infrastructure.Repositories;

namespace ApiWebPrueba.Application.UseCases
{
    public class PersonasUseCase : IPersonasUseCase
    {
        private readonly IMapper _mapper;

        public PersonasUseCase()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ApplicationProfile>();
                cfg.AddExpressionMapping();
            });
            this._mapper = new Mapper(mapConfig);
        }

        public Response<ICollection<PersonasDTO>> ListarPersonas()
        {
            var response = new Response<ICollection<PersonasDTO>>();

            try
            {
                using (var personasRepository = new PersonasRepository())
                {
                    response.Data = _mapper.Map<ICollection<PersonasDTO>>(new PersonasService(personasRepository).ListarPersonas());
                }
                response.Succeeded = true;
            }
            catch (Exception e)
            {
                response.Message = e.ToString();
                response.Succeeded = false;
            }

            return response;
        }
    }
}
