using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //variables
        double saldo = 1000;
        int intentos = 0;
        int pinCorrecto = 1234;
        int pin;

        //validar el pin /acceso
        while (intentos < 3)
        {
            Console.Write("Ingrese su PIN: ");
            if (int.TryParse(Console.ReadLine(), out pin))
            {
                if (pin == pinCorrecto)
                {
                    Console.WriteLine("Acceso concedido");

                    int opcion = 0;
                    //Menu de cajero
                    while (opcion != 4)
                    {
                        Console.WriteLine("\nSeleccione una opción:");
                        Console.WriteLine("1. Consultar saldo");
                        Console.WriteLine("2. Retirar dinero");
                        Console.WriteLine("3. Depositar dinero");
                        Console.WriteLine("4. Salir");
                        if (int.TryParse(Console.ReadLine(), out opcion))
                        {
                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("Consulta de saldo:");
                                    Console.WriteLine($"Su saldo actual: Q" + saldo);
                                    break;
                                case 2: 
                                    Console.WriteLine("Retirar dinero:");
                                    Console.WriteLine("Ingrese la cantidad a retirar: ");
                                    if (double.TryParse(Console.ReadLine(), out double retiro))
                                    {
                                        if (retiro <= saldo)
                                        {
                                            saldo -= retiro;
                                            Console.WriteLine($"Retiro exitoso. Nuevo saldo: Q{saldo}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Saldo insuficiente.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cantidad inválida.");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Depositar dinero");
                                    Console.WriteLine("Ingrese la cantidad a depositar: ");
                                    if (double.TryParse(Console.ReadLine(), out double deposito))
                                    {
                                        saldo += deposito;
                                        Console.WriteLine($"Depósito exitoso. Nuevo saldo: Q{saldo}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cantidad inválida.");
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Gracias por usar el cajero automático.");
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                        }
                    }
                }
            }
            else
            {
                intentos++;
                Console.WriteLine("Pin  incorrectp, intentos"+intentos+" de 3\n");
            }
        }
        {
            Console.WriteLine("Ingrese un Pin valido");
        }
        //Bloque de la tarjeta
        Console.WriteLine("Tarjeta bloqueada \nDemasiados Intentos Fallidos.");
    }
}