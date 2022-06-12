using DTEuropAEmmanuelJulio.Interface;
using DTEuropAEmmanuelJulio.Manager;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddTransient<IValidate, Validate>();
services.AddTransient<IService, Service>();
var servicesProvider = services.BuildServiceProvider();
var service = servicesProvider.GetRequiredService<IService>();


bool salir = false;
while (!salir)
{
    Console.WriteLine("Ingrese una opcion");
    Console.WriteLine("1) Realizar simplificacion en fraccion");
    Console.WriteLine("2) Comprobar formato de nombre valido");
    string option = Console.ReadLine();
    switch (option)
    {
        case "1":
                Console.WriteLine("Ingrese una fraaccion en formato 'num1/num2'");
                Console.WriteLine(service.Simplificar(Console.ReadLine()));
                Console.WriteLine("Salir s/n");
                
            break;
        case "2":
                Console.WriteLine("Ingrese un nombre valido");
                Console.WriteLine(service.ValidName(Console.ReadLine()) ? "el nombre ingresado es valido": "El nombre ingrsado es invalido");
                Console.WriteLine("Salir s/n");
                
            break;
        default:
        Console.WriteLine("Opcion invalida");
                Console.WriteLine("Salir s/n");
            break;
    }
    if (Console.ReadLine() == "s")
    {
        salir = true;
        Console.Clear();
    }
}

