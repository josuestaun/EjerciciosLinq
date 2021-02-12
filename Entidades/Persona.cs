using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona : IEquatable<Persona>
    {
        public String Id { get; set; }
        public String IdProvincia { get; set; }
        public String Nombre { get; set; }
        public String Localidad { get; set; }
        public int Edad { get; set; }
        public List<String> Telefonos { get; set; }
        public Persona() { }
        public Persona(string id, string nombre, int edad, string localidad, string idProvincia)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Localidad = localidad;
            IdProvincia = idProvincia;
        }
        public Persona(string id, string nombre, int edad, string localidad, string idProvincia, List<string> telefonos) : this(id, nombre, edad, localidad, idProvincia)  // llamada al constructor anterior
        {
            Telefonos = telefonos; // añadir los teléfonos
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Persona);
        }

        public bool Equals(Persona other)
        {
            return other != null && Id == other.Id;
        }

    }
}
