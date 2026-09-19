
namespace SistemaBancario.Models;

class Program
{
    static void Main(string[] args)
    {

        List<CuentaBancaria> cuentas = new List<CuentaBancaria>
     {
         new CuentaAhorros(5000, 0.02m), // Cuenta de ahorros con saldo de 5000 y tasa promocional del 2%
         new CuentaInversion(15000, 5.5), // Cuenta de inversión con saldo de 15000 y factor de riesgo de 1.5   
     };


        foreach (var cuenta in cuentas)
        {
            Console.WriteLine($"Saldo: {cuenta.Saldo}, Interés Mensual: {cuenta.CalcularInteresMensual()}");
        }

    }
}