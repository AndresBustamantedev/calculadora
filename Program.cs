using System;

class ProgramaCalculadora
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido! Vamos a realizar algunos cálculos.");

        bool continuarPrograma = true;

        while (continuarPrograma)
        {
            Console.WriteLine("\nPor favor, ingresa dos números no negativos para comenzar.");
            double primerNumero = SolicitarNumeroNoNegativo("Ingresa el primer número:");
            double segundoNumero = SolicitarNumeroNoNegativo("Ingresa el segundo número:");

            while (true)
            {
                Console.WriteLine("\n--- Menú de la Calculadora ---");
                Console.WriteLine("1. Sumar (+)");
                Console.WriteLine("2. Restar (-)");
                Console.WriteLine("3. Multiplicar (*)");
                Console.WriteLine("4. Dividir (/)");
                Console.WriteLine("5. Salir del programa.");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine()?.Trim() ?? string.Empty;

                if (opcion == "5")
                {
                    continuarPrograma = false;
                    break;
                }

                RealizarCalculo(opcion, primerNumero, segundoNumero);

                Console.WriteLine("¿Quieres realizar otro cálculo con los mismos números? (sí/no)");
                string continuarConMismosNumeros = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

                if (continuarConMismosNumeros == "no")
                {
                    break;
                }
            }
        }

        Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
    }

    private static double SolicitarNumeroNoNegativo(string mensaje)
    {
        while (true)
        {
            Console.WriteLine(mensaje);
            if (double.TryParse(Console.ReadLine(), out double resultado) && resultado >= 0)
            {
                return resultado;
            }
            Console.WriteLine("Entrada no válida. Por favor, ingresa un número no negativo.");
        }
    }

    private static void RealizarCalculo(string operacion, double num1, double num2)
    {
        switch (operacion)
        {
            case "1":
            case "+":
                Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                break;
            case "2":
            case "-":
                Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                break;
            case "3":
            case "*":
                Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                break;
            case "4":
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
                else
                {
                    Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                }
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, selecciona una operación válida.");
                break;
        }
    }
}
