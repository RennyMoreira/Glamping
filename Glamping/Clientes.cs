using Glamping.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamping.Logica
{
    public abstract class Clientes
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public string? Correo { get; set; }
        public int Celular { get; set; }
        public int Huespedes { get; set; }

        public string? _reservar { get; set; }
        public string? _pago { get; set; }

        // Propiedad que permite obtener y establecer el día de la reserva, validando que sea un día válido.
        public string? Reservar
        {
            get => _reservar;
            set => _reservar = ValidateReservar(value?.ToUpper());
        }
        public string? Pago
        {
            get => _pago;
            set => _pago = ValidatePago(value?.ToUpper());
        }

        

        public override string ToString()
        {
            return $"Nombre..................:{Nombre,20}\n" +
                   $"Apellido................:{Apellido,20}\n" +
                   $"Correo..................:{Correo,20}\n" +
                   $"Celular.................:{Celular,20}\n" +
                   $"Huespedes...............:{Huespedes,20}\n" +
                   $"Tipo de pago............:{Pago,20}\n" +
                   $"Dia de reserva..........:{Reservar,20}\n";
                  
                  

                  
        }

        // Método privado para validar si el día de reserva es válido.
        private string? ValidateReservar(string? value)
        {
            if (value == "JUEVES" || value == "VIERNES" || value == "SÁBADO" || value == "DOMINGO")

            {
                return value;

            }
            throw new ArgumentException("Día no inválido. Los días permitidos son jueves, viernes, sabado y domingo.");
        }

        private string? ValidatePago(string? value)
        {
            if (value == "EFECTIVO" || value == "TRANSFERENCIA" || value == "TARJETA")
            {
                return value;
            }
            throw new ArgumentException("Forma de Pago Inválida.");
        }

        // Método abstracto que debe ser implementado por las clases derivadas para calcular el valor a pagar.
        public abstract decimal GetValueToPay();
    }
}
