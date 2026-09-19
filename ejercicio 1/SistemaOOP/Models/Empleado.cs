namespace SistemaOOP.Models;

public class Empleado
{
    public string? Nombre { get; set; }
    public decimal SalarioBase { get; set; }


   public Empleado(string? nombre, decimal salarioBase)
    {
        Nombre = nombre;
        SalarioBase = salarioBase;
    }

    public virtual decimal CalcularSalarioTotal()
    {
        return SalarioBase;
    }





}
