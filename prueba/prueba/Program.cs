using System;

public class Program
{
    static void Main()
    {
        while (true)
        {
            MostrarMenu();
            int opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;
                case 5:
                    Ejercicio5();
                    return;
                case 6:
                    Console.WriteLine("Saliendo del programa.");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("----- Menú de Ejercicios -----");
        Console.WriteLine("1. Ejercicio 1");
        Console.WriteLine("2. Ejercicio 2");
        Console.WriteLine("3. Ejercicio 3");
        Console.WriteLine("4. Ejercicio 4");
        Console.WriteLine("5. Ejercicio 5");
        Console.WriteLine("6. Salir");
        Console.Write("Selecciona una opción: ");
    }

    static int ObtenerOpcion()
    {
        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Ingresa un número válido.");
            Console.Write("Selecciona una opción: ");
        }
        return opcion;
    }

    static void Ejercicio1()
    {
        Console.WriteLine("----- Ejercicio 1 -----");
        //Declarar dos variables e inicializarlas con valores numericos
        int numero1 = 15;
        int numero2 = 10;

        // Calcular la suma y almacenar el resultado en una tercera variable
        int resultado = numero1 + numero2;

        // Imprimir el valor de resultado en la consola
        Console.WriteLine("La suma de {0} y {1} es: {2}", numero1, numero2, resultado);
    }

    static void Ejercicio2()
    {
        Console.WriteLine("----- Ejercicio 2 -----");
        // Declarar una variable de edad e inicializarla
        int edad = 25;

        // Utilizar una estructura if para verificar si es mayor de edad
        if (edad >= 18)
        {
            // Imprimir un mensaje indicando que la persona es mayor de edad
            Console.WriteLine("La persona es mayor de edad.");
        }
        else
        {
            // Imprimir un mensaje indicando que la persona no es mayor de edad
            Console.WriteLine("La persona no es mayor de edad.");
        }
    }

    static void Ejercicio3()
    {
        Console.WriteLine("----- Ejercicio 3 -----");
       
        // Crear un objeto de tipo Estudiante y asignar valores ficticios
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "Sebastian";
        estudiante1.Edad = 21;
        estudiante1.Calificacion = 9.5;

        // Imprimir la información del estudiante en la consola
        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine($"Nombre: {estudiante1.Nombre}");
        Console.WriteLine($"Edad: {estudiante1.Edad} años");
        Console.WriteLine($"Calificación: {estudiante1.Calificacion}");
    }

    static void Ejercicio4()
    {
        Console.WriteLine("----- Ejercicio 4 -----");
        Estudiante estudiante2 = new Estudiante();
        estudiante2.Nombre = "Ana";
        estudiante2.Edad = 25;
        estudiante2.Calificacion = 9.0;
        estudiante2.MostrarInformacion();
       
    }

    static void Ejercicio5()
    {
        Console.WriteLine("----- Ejercicio 4 -----");
        // Crear un objeto de tipo EstudianteGraduado y asignar valores ficticios
        EstudianteGraduado graduado1 = new EstudianteGraduado();
        graduado1.Nombre = "Sebastian";
        graduado1.Edad = 25;
        graduado1.Calificacion = 9.0;
        graduado1.Titulo = "Ingeniero en Informática";

        // Utilizar el método MostrarInformacion de la clase base para mostrar la información del estudiante graduado
        graduado1.MostrarInformacion();
        Console.WriteLine($"Título Obtenido: {graduado1.Titulo}");
    }

}


class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }
    public string Titulo { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine($"Calificación: {Calificacion}");
    }
}
class EstudianteGraduado : Estudiante
{
    //Añadir una nueva propiedad a EstudianteGraduado llamada Titulo
    public string Titulo { get; set; }
}