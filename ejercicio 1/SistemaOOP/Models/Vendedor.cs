namespace SistemaOOP.Models;
public class Vendedor : Empleado
{
    public int CantidadVentas { get; set; }
    public Vendedor(string? nombre, decimal salarioBase, int cantidadVentas)
     : base(nombre, salarioBase)
    {
        CantidadVentas = cantidadVentas;
    }

    public override decimal CalcularSalarioTotal()
    {
         return SalarioBase + (CantidadVentas * 100m); // Suponiendo que cada venta agrega 100 al salario
    }
}