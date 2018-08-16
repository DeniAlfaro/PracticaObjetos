using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaObjetos
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoCasa { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }

        public Contacto()
        {
            Nombre = "Nuevo Contacto";
            TelefonoCasa = "(000) 000 00 00";
        }

        public Contacto(string nombre)
        {
            Nombre = nombre;
        }
        //No marca error porque hay varios strings y no uno como en el anterior, no tiene que tener el mismo numero de strings)
        public Contacto(string nombre, string telefonoCelular, string telefonoCasa, string direccion, string correoElectronico)
        {
            Nombre = nombre;
            TelefonoCelular = telefonoCelular;
            TelefonoCasa = telefonoCasa;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
        }
    }
}
