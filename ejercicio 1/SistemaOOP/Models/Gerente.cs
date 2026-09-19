namespace SistemaOOP.Models;
public class Gerente : Empleado
{
    public decimal BonoAnualFijo { get; set; }
    public Gerente(string? nombre, decimal salarioBase, decimal bonoAnualFijo)
     : base(nombre, salarioBase)
    {
        BonoAnualFijo = bonoAnualFijo;
    }

    public override decimal CalcularSalarioTotal()
    {
         return SalarioBase +  (BonoAnualFijo / 12); // Suponiendo que el bono anual se distribuye mensualmente
    }
}