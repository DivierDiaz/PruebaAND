using ApiWebPrueba.Domain.Personas.Entities;
using ApiWebPrueba.Domain.Personas.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWebPrueba.Domain.Personas.Services
{
    public class PersonasService
    {
        private readonly IPersonasRepository _personaRepository;

        public PersonasService(IPersonasRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }
        public ICollection<PersonasEntity> ListarPersonas()
        {
            try
            {
                return _personaRepository.ListarPersonas();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
