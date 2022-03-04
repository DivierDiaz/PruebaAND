using ApiWebPrueba.Application.DTO;
using ApiWebPrueba.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWebPrueba.Application.UseCases.Interface
{
    public interface IPersonasUseCase
    {
        Response<ICollection<PersonasDTO>> ListarPersonas();
    }

}
