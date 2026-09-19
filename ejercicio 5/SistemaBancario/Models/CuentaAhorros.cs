namespace SistemaBancario.Models;

public class CuentaAhorros : CuentaBancaria
{
    public decimal TasaPromocional { get; set; }
    
    public CuentaAhorros(decimal saldo, decimal tasaPromocional) : base(saldo)
    {
        TasaPromocional = tasaPromocional;
    }
    
    public override decimal CalcularInteresMensual()
    {
        return Saldo * TasaPromocional; 
    }

}