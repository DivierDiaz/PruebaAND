using ApiWebPrueba.Domain.Personas.Entities;
using ApiWebPrueba.Domain.Personas.IRepositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ApiWebPrueba.Infrastructure.Repositories
{
    public class PersonasRepository : IPersonasRepository, IDisposable
    {
        public void Dispose()
        {          
        }

        public ICollection<PersonasEntity> ListarPersonas()
        {
            try
            {

                ICollection<PersonasEntity> lista = new Collection<PersonasEntity>();
                PersonasEntity persona0 = new PersonasEntity()
                {
                    Identificacion = 10001,
                    Nombre = "Joanna Palomino",
                    Correo = "JohannaPalomino@gmail.com",
                    FechaNacimiento = DateTime.Now.AddYears(-18),
                    Celular = "31145087871",
                    Direccion = "Carrera 14 OC # 15-60",
                    Estado = true,
                };

                PersonasEntity persona1 = new PersonasEntity()
                {
                    Identificacion = 10002,
                    Nombre = "Carlos Palomino",
                    Correo = "CarlosPalomino@gmail.com",
                    FechaNacimiento = DateTime.Now.AddYears(-35),
                    Celular = "31145887871",
                    Direccion = "Carrera 14 OC # 15-60",
                    Estado = true,
                };
                PersonasEntity persona2 = new PersonasEntity()
                {
                    Identificacion = 454545,
                    Nombre = "Divier Diaz ",
                    Correo = "DivierDiaz@gmail.com",
                    FechaNacimiento = DateTime.Now.AddYears(-36),
                    Celular = "3114512066",
                    Direccion = "Balcones de cofrem Restrepo Meta",
                    Estado = true,
                };

                PersonasEntity persona3 = new PersonasEntity()
                {
                    Identificacion = 545454,
                    Nombre = "Thomas Diaz ",
                    Correo = "ThomasDiaz@gmail.com",
                    FechaNacimiento = DateTime.Now.AddYears(-6),
                    Celular = "3114512066",
                    Direccion = "Balcones de cofrem Restrepo Meta",
                    Estado = true,
                };

                PersonasEntity persona4 = new PersonasEntity()
                {
                    Identificacion = 1001001,
                    Nombre = "Enrique Diaz ",
                    Correo = "EnriqueDiaz@gmail.com",
                    FechaNacimiento = DateTime.Now.AddYears(-62),
                    Celular = "3114512066",
                    Direccion = "Calle 13 # 17-02 Centro Cumaral Meta",
                    Estado = true,
                };

                PersonasEntity persona5 = new PersonasEntity()
                {
                    Identificacion = 20020021,
                    Nombre = "Jose Jose ",
                    Correo = "JoseJose@gmail.com",
                    FechaNacimiento = DateTime.Now.AddYears(-87),
                    Celular = "3203200401",
                    Direccion = "Calle 13 # 17-02 Bogota",
                    Estado = true,
                };

                PersonasEntity persona6 = new PersonasEntity()
                {
                    Identificacion = 9999999,
                    Nombre = "amparo grisales",
                    Correo = "amparogrisales@gmail.com",
                    FechaNacimiento = DateTime.Now.AddYears(-1009),
                    Celular = "31100000001",
                    Direccion = "Calle falsa 123",
                    Estado = true,
                };

                lista.Add(persona0);
                lista.Add(persona1);
                lista.Add(persona2);
                lista.Add(persona3);
                lista.Add(persona4);
                lista.Add(persona5);
                lista.Add(persona6);

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
