using System;

namespace DemoAuditApp
{
    /// <summary>
    /// Clase principal que ejecuta la aplicación de consola.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Punto de entrada del programa. Solicita y valida la edad del usuario.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingrese su edad:");
            string? input = Console.ReadLine();
            // 1. CONTROL PREVENTIVO: Validación segura con int.TryParse
            if (int.TryParse(input, out int edad))
            {
                // 2. MANEJO DE EXCEPCIONES Y LÓGICA: Control de rangos lógicos
                try
                {
                    if (edad >= 18)
                    {
                        Console.WriteLine("Acceso concedido: Usted es mayor de edad.");
                    }
                    else if (edad < 0 || edad > 120)
                    {
                        throw new ArgumentOutOfRangeException("La edad ingresada no está en un rango biológico válido.");
                    }
                    else
                    {
                        Console.WriteLine("Acceso denegado: Usted es menor de edad.");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error de validación: {ex.Message}");
                }
            }
            else
            {
                // Mitigación del Crash: Si mete letras, muestra un mensaje controlado en lugar de romperse
                Console.WriteLine("Error: La entrada ingresada no es un número válido.");
            }
        }
    }
}