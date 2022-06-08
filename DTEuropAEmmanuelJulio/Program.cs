using DTEuropAEmmanuelJulio.Manager;
Validate validate = new Validate();
Service service = new Service(validate);

bool salir = false;
while (!salir)
{
Console.WriteLine("Ingrese una fraaccion en formato 'num1/num2'");
Console.WriteLine(service.Simplificar(Console.ReadLine()));
Console.WriteLine("Salir s/n");
    if(Console.ReadLine()=="s")
        salir = true;
}

