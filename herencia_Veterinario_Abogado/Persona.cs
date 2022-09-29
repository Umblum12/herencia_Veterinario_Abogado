using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_Veterinario_Abogado
{
    internal class Persona
    {
        private string nombre;
        private int edad;
        private double peso;
        private double estatura;
        private string ColorOjos;
        private string Sexo;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Peso { get => peso; set => peso = value; }
        public string ColorOjos1 { get => ColorOjos; set => ColorOjos = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public double Estatura { get => estatura; set => estatura = value; }
    }
}
