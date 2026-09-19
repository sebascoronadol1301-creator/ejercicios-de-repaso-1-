//Ejercicio 4: Centro de Envíos de Alertasy Notificaciones Multicanal
using System;
using System.Collections.Generic;

namespace CentroNotificaciones
{
    // Clase Base
    public class Notificacion
    {
        public string Mensaje { get; set; }

        public Notificacion(string mensaje)
        {
            Mensaje = mensaje;
        }

        public virtual void Enviar()
        {
            Console.WriteLine($"[Notificación General] Mensaje: {Mensaje}");
        }
    }

    // Clase Derivada: CorreoElectronico
    public class CorreoElectronico : Notificacion
    {
        public string DireccionCorreo { get; set; }

        public CorreoElectronico(string mensaje, string direccionCorreo) : base(mensaje)
        {
            DireccionCorreo = direccionCorreo;
        }

        public override void Enviar()
        {
            Console.WriteLine($"[EMAIL enviado a {DireccionCorreo}] Protocolo SMTP -> Alerta: {Mensaje}");
        }
    }

    // Clase Derivada: Sms
    public class Sms : Notificacion
    {
        public string NumeroTelefono { get; set; }

        public Sms(string mensaje, string numeroTelefono) : base(mensaje)
        {
            NumeroTelefono = numeroTelefono;
        }

        public override void Enviar()
        {
            Console.WriteLine($"[SMS enviado a {NumeroTelefono}] Protocolo GSM -> Alerta: {Mensaje}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Despachador central utilizando polimorfismo
            List<Notificacion> alertas = new List<Notificacion>
            {
                new CorreoElectronico("Servidor web fuera de línea", "admin@empresa.com"),
                new Sms("Fallo crítico de memoria en Nodo 3", "+50255551234")
            };

            foreach (var alerta in alertas)
            {
                alerta.Enviar(); // Ejecuta el método específico de cada vía de comunicación
            }
        }
    }
}