//Ejercicio 2: Ecosistema de Dispositivos Multimedia en el Hogar
using System;
using System.Collections.Generic;

namespace EcosistemaMultimedia
{
    // Clase Base
    public class Dispositivo
    {
        public string Marca { get; set; }

        public Dispositivo(string marca)
        {
            Marca = marca;
        }

        // Método virtual para permitir el comportamiento polimórfico
        public virtual void ReproducerMedia()
        {
            Console.WriteLine($"[Dispositivo {Marca}] Reproduciendo contenido multimedia genérico...");
        }
    }

    // Clase Derivada: SmartTv
    public class SmartTv : Dispositivo
    {
        public string Resolucion { get; set; }

        public SmartTv(string marca, string resolucion) : base(marca)
        {
            Resolucion = resolucion;
        }

        public override void ReproducerMedia()
        {
            Console.WriteLine($"[SmartTV {Marca}] Reproduciendo video en resolución {Resolucion}.");
        }
    }

    // Clase Derivada: ParlanteInteligente
    public class ParlanteInteligente : Dispositivo
    {
        public int PotenciaWatts { get; set; }

        public ParlanteInteligente(string marca, int potenciaWatts) : base(marca)
        {
            PotenciaWatts = potenciaWatts;
        }

        public override void ReproducerMedia()
        {
            Console.WriteLine($"[Parlante {Marca}] Emitiendo perfil acústico personalizado a {PotenciaWatts}W de potencia.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dispositivo> dispositivos = new List<Dispositivo>
            {
                new SmartTv("Samsung", "4K UHD"),
                new ParlanteInteligente("Bose", 60)
            };

            foreach (var dispositivo in dispositivos)
            {
                dispositivo.ReproducerMedia(); // Llamada polimórfica
            }
        }
    }
}