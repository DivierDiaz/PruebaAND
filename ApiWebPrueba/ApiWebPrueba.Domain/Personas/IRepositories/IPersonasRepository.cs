using ApiWebPrueba.Domain.Personas.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWebPrueba.Domain.Personas.IRepositories
{
    public interface IPersonasRepository
    {
        ICollection<PersonasEntity> ListarPersonas();
    }
}
