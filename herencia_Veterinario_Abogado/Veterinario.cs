using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_Veterinario_Abogado
{
    internal class Veterinario : Persona
    {
        private string cedula;
        private string Especialidad;
        public string Cedula { get => cedula; set => cedula = value; }
        public string Especialidad1 { get => Especialidad; set => Especialidad = value; }
    }
}
