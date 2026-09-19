namespace SistemaBancario.Models;

public class CuentaInversion : CuentaBancaria
{
    public double FactorRiesgo { get; set; }
    
    public CuentaInversion(decimal saldo, double factorRiesgo) : base(saldo)
    {
        FactorRiesgo = factorRiesgo;
    }
    
    public override decimal CalcularInteresMensual()
    {
       decimal tasaDinamica = Saldo > 10000 ? 0.02m : 0.015m; // Interés del 2% si el saldo es mayor a 10,000, de lo contrario 1.5%
       return Saldo * tasaDinamica * (decimal)FactorRiesgo;
    }

}