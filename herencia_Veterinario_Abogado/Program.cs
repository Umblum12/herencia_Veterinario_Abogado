namespace herencia_Veterinario_Abogado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("\n---------------------------------");
            Persona persona1 = new Persona();
            persona1.Nombre = "Abelardo Cruz Leos.";
            persona1.Edad = 19;
            persona1.Peso = 89;
            persona1.Estatura = 1.57;
            persona1.ColorOjos1 = "Ambar";
            persona1.Sexo1 = "Masculino";
            Console.WriteLine("=<!Persona!>= \nNombre: " + persona1.Nombre + "\nEdad: " + persona1.Edad + "\nPeso: " + persona1.Peso + "\nEstatura: " + persona1.Estatura + "\nColor de Ojos: " + persona1.ColorOjos1 + "\nSexo: " + persona1.Sexo1);
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("\n---------------------------------");

            Abogado abogado = new Abogado();
            abogado.Nombre = "Alan Ernesto Cruz Leos";
            abogado.Edad = 28;
            abogado.Peso = 80;
            abogado.Estatura = 1.85;
            abogado.ColorOjos1 = "Marron";
            abogado.Sexo1 = "Masculino";
            abogado.Titulo1 = "Licenciado en Derecho";
            abogado.Cursos1 = "Licenciatura";
            Console.WriteLine("=<!Abogado!>= \nNombre: " + abogado.Nombre + "\nEdad: " + abogado.Edad + "\nPeso: " + abogado.Peso + "\nEstatura: " + abogado.Estatura + "\nColor de Ojos: " + abogado.ColorOjos1 + "\nSexo: " + abogado.Sexo1 + "\nTitulo: " + abogado.Titulo1 + "\nCursos: " + abogado.Cursos1);
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("\n---------------------------------");
            Veterinario veterinario = new Veterinario();
            veterinario.Nombre = "Claudia Danyra Aguilar Muñoz";
            veterinario.Edad = 20;
            veterinario.Peso = 68;
            veterinario.Estatura = 1.60;
            veterinario.ColorOjos1 = "Marron";
            veterinario.Sexo1 = "Femenino";
            veterinario.Cedula = "Medico Veterinario";
            veterinario.Especialidad1 = "Cirugia";
            Console.WriteLine("=<!Veterinario!>= \nNombre: " + veterinario.Nombre + "\nEdad: " + veterinario.Edad + "\nPeso: " + veterinario.Peso + "\nEstatura: " + veterinario.Estatura + "\nColor de Ojos: " + veterinario.ColorOjos1 + "\nSexo: " + veterinario.Sexo1 + "\nCedula: " + veterinario.Cedula + "\nEspecialidad: " + veterinario.Especialidad1);
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("\n---------------------------------");
            Console.ReadKey(true);
        }
    }
}