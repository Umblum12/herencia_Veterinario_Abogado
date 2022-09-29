using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_Veterinario_Abogado
{
    internal class Abogado : Persona
    {
        private string Titulo;
        private string Cursos;
        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public string Cursos1 { get => Cursos; set => Cursos = value; }
    }
}
