using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWebPrueba.Application.DTO
{
    public class PersonasDTO
    {
        public int Identificacion { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public string Celular { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }

        public Boolean Estado { get; set; }
    }
}
