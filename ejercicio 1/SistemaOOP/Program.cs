namespace SistemaOOP.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>
        {
            new Desarrollador("Juan", 3000m, 100),
            new Gerente("Maria", 5000m, 12000m),
            new Vendedor("Carlos", 2500m, 30),
            new Diseñador("Ana", 2800m, 2)
        };

        Console.WriteLine("Salarios de los empleados:");
        
        foreach (var emp in empleados)
        {
            Console.WriteLine($"Nombre: {emp.Nombre}, Salario Total: {emp.CalcularSalarioTotal():C}");
        }



   
   }
}