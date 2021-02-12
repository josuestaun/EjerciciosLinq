using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia : IEquatable<Provincia>
    {
        public String Id { get; set; }
        public String Nombre { get; set; }

        public Provincia() { }
        public Provincia(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Provincia);
        }
        public bool Equals(Provincia other)
        {
            return other != null && Id == other.Id;
        }
        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}
