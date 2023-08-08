using Glamping.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamping.Logica
{
    //Clase que define la información de reserva
    public class Reserva
    {
        public string? _dia;
        public string? _formapago;
        private object value;

        public Reserva()
        {
            _dia = "Sabado";
            _formapago = "Efectivo";
           
        }

        public Reserva(string? dia, string? formapago)
        {
            _dia = ValidateDia(dia);
            _formapago = ValidateFormapago(formapago);
        }


        // Propiedad que permite obtener y establecer el día de la reserva.
        public string? Dia
        {
            get => _dia;
            set => _dia = ValidateDia(value);
        }
        

        public string? Formapago
        {
            get => _formapago;
            set => _formapago = ValidateFormapago(value?.ToUpper());
        }
        

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Dia....................:{Dia,20:C2}\n\t";
               
           


        }
        
        // Método privado para validar si el día de reserva es válido.
        private string? ValidateDia(string? value)
        {
            if (value == "jueves" || value == "viernes" || value == "sabado" || value == "domingo")

            {
                return value;

            }
            throw new ArgumentException("Día no inválido. Los días permitidos son Jueves, viernes, sabado y domingo.");
        }
        private string? ValidateFormapago(string? value)
        {
            if (value == "efectivo" || value == "transferencia" || value == "tarjeta")
            {
                return value;
            }
                throw new ArgumentException("Forma de Pago Inválida.");
        }
    }
}
