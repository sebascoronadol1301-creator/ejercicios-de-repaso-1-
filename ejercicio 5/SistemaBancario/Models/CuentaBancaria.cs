namespace SistemaBancario.Models;

public class CuentaBancaria
{
    public decimal Saldo { get; set; }

    public CuentaBancaria(decimal saldo)
    {
        Saldo = saldo;
    }

    public virtual decimal CalcularInteresMensual()
    {
        return Saldo * 0.01m; // Interés mensual del 1%
    }



}
