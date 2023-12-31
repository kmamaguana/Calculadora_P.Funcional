
// Definición del programa principal
class Program
{
    // Función principal
    static void Main()
    {
        // Bucle do-while para permitir ejecutar el programa múltiples veces
        do
        {
            // Mensaje de bienvenida y solicitud del primer número
            Console.WriteLine("----------Bienvenido:----------");
            Console.WriteLine("Calculadora (Programación Funcional)");
            Console.WriteLine("Ingrese el primer número:");
            // Llamada a la función para obtener un número válido
            double num1 = GetValidNumber();

            // Mensaje y solicitud de la operación
            Console.WriteLine("Ingrese la operación (+, -, *, /):");
            // Llamada a la función para obtener una operación válida
            char operation = GetValidOperation();

            // Mensaje y solicitud del segundo número
            Console.WriteLine("Ingrese el segundo número:");
            // Llamada a la función para obtener un número válido
            double num2 = GetValidNumber();

            // Llamada a la función para realizar la operación y obtener el resultado
            double result = PerformOperation(num1, num2, operation);
            // Mostrar el resultado
            Console.WriteLine($"El resultado es: {result}");

            // Preguntar al usuario si desea continuar
            Console.WriteLine("¿Desea realizar otra operación? (S/N)");
        } while (Console.ReadLine().ToUpper() == "S");
    }

    // Función para obtener un número válido
    static double GetValidNumber()
    {
        double number;
        // Bucle hasta que se ingrese un número válido
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Ingrese un número válido:");
        }
        return number;
    }

    // Función para obtener una operación válida
    static char GetValidOperation()
    {
        char operation;
        // Bucle hasta que se ingrese una operación válida
        while (!char.TryParse(Console.ReadLine(), out operation) || !IsValidOperation(operation))
        {
            Console.WriteLine("Ingrese una operación válida (+, -, *, /):");
        }
        return operation;
    }

    // Función para verificar si la operación es válida
    static bool IsValidOperation(char operation)
    {
        return operation == '+' || operation == '-' || operation == '*' || operation == '/';
    }

    // Función para realizar la operación
    static double PerformOperation(double num1, double num2, char operation)
    {
        // Estructura switch para determinar la operación a realizar
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                // Verificar la división por cero
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    // Mostrar un mensaje de error y devolver NaN
                    Console.WriteLine("Error: No se puede dividir por cero.");
                    return double.NaN;
                }
            default:
                // Mostrar un mensaje de error y devolver NaN
                Console.WriteLine("Error: Operación no válida.");
                return double.NaN;
        }
    }
}
