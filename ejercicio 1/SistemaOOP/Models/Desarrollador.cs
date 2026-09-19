namespace SistemaOOP.Models;

public class Desarrollador : Empleado
{
    public int LineasCodigoPorDia { get; set; }
    public Desarrollador(string? nombre, decimal salarioBase, int lineasCodigoPorDia)
     : base(nombre, salarioBase)
    {
        LineasCodigoPorDia = lineasCodigoPorDia;    
    }

    public override decimal CalcularSalarioTotal()
    {
        
        return SalarioBase + (LineasCodigoPorDia * 0.5m); // Suponiendo que cada línea de código adicional agrega 0.5 al salario
    }
}