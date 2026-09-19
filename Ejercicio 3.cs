//Ejercicio 3: Autonomía de Flota Vehicular y Eficiencia Energética
using System;
using System.Collections.Generic;

namespace FlotaVehicular
{
    // Clase Base
    public class Vehiculo
    {
        public double LitrosCombustible { get; set; }

        public Vehiculo(double litrosCombustible)
        {
            LitrosCombustible = litrosCombustible;
        }

        public virtual double CalcularAutonomiaKm()
        {
            // Valor por defecto base
            return LitrosCombustible * 10.0;
        }
    }

    // Clase Derivada: Automovil
    public class Automovil : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public Automovil(double litrosCombustible, int numeroPuertas) : base(litrosCombustible)
        {
            NumeroPuertas = numeroPuertas;
        }

        public override double CalcularAutonomiaKm()
        {
            // Asumiendo un rendimiento promedio de 15 km por litro para automóviles
            return LitrosCombustible * 15.0;
        }
    }

    // Clase Derivada: Camion
    public class Camion : Vehiculo
    {
        public double CapacidadCargaTon { get; set; }

        public Camion(double litrosCombustible, double capacidadCargaTon) : base(litrosCombustible)
        {
            CapacidadCargaTon = capacidadCargaTon;
        }

        public override double CalcularAutonomiaKm()
        {
            // El rendimiento disminuye según el peso de la carga (ejemplo: base de 4 km/L con penalización por tonelada)
            double rendimientoPorLitro = Math.Max(1.0, 5.0 - (CapacidadCargaTon * 0.2));
            return LitrosCombustible * rendimientoPorLitro;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> flota = new List<Vehiculo>
            {
                new Automovil(40.0, 4),
                new Camion(120.0, 10.0)
            };

            foreach (var vehiculo in flota)
            {
                Console.WriteLine($"Autonomía estimada: {vehiculo.CalcularAutonomiaKm()} km");
            }
        }
    }
}
