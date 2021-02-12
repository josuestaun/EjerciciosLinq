using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Gestion
{
    public class Ejercicios
    {
        List<Provincia> provincias = new List<Provincia>  { new Provincia ("NA", "Navarra"),
                                                                new Provincia("SS", "Gipuzkoa"),
                                                                new Provincia("BI", "Bizkaia"),
                                                                new Provincia ("SA", "Salamanca"),
                                                                };
        // Podemos inicializarla en el momento de la declaración, usando el constructor con parámetros o indicando el nombre de las propiedades y su valor

        List<Persona> personas = new List<Persona>{
                new Persona ("1", "Primera50Navarra",  50, "Iruñea", "NA", new List<String> { "948121212", "676676676" }),
                new Persona("2", "Segunda40Nav", 40, "Barañain", "NA"),
                new Persona("3", "Tercera20Gi", 20,  "Donostia", "SS", new List<String> { "943121415"}),
                new Persona("4", "Cuarta10NA", 10,  "Barañain", "NA",  new List<String>  { "954534543", "121313657575757", "9345334"}),
                new Persona("5","Quinta15Na",  15,  "Burlada", "NA", new List<String> {"654534543", "65456546", "69345334"}),
                new Persona("6", "Sexta20SS", 20, "Andoain", "SS"),
                new Persona("7", "Septima21SS", 51,"Hernani", "SS"),
                new Persona("8", "OctavaNA", 23, "Iruñea", "NA"),
                new Persona("9", "Tercera20Gi", 20, "Iruñea", "NA"),
               };

        //EJERCICIO1
        //Método que reciba un trozo de nombre de persona y devuelva una colección con las
        //personas que tengan ese comienzo de nombre.
        public List<Persona> PersonasComienzanA(string name, out string msj)
        {
            msj = "";
            var personasComienzan = from person in personas
                                    where person.Nombre.ToUpper().StartsWith(name.ToUpper())
                                    select person;
            if (personasComienzan.Count() < 1)
            {
                msj = "No hay nadie que comience por " + name;
            }

            return personasComienzan.ToList();
        }

        //EJERCICIO2
        //Método que reciba el nombre de una localidad y devuelva un boolean, indicando si existe o
        //no alguna persona de esa localidad
        public Boolean ExistEnLocalidad(string localidad)
        {
            //revisar, no puede ser mas de 1
            var exist = personas.Any(p => p.Localidad.ToUpper().Equals(localidad.ToUpper()));
            return exist;
            
        }

        //EJERCICIO03
        //Método que devuelva la persona correspondiente a un identificador pasado como
        //parámetro.
        public Persona personaPorIdentificador(string identificador)
        {
            var unicaPerONull = personas.SingleOrDefault(p => p.Id.Equals(identificador));
            return unicaPerONull;
        }

        //EJERCICIO04
        //Modifica el apartado anterior, para que, en la parte del formulario, el mensaje indique
        //también la cantidad de teléfonos que tiene:
        public int CantidadTelefonos(string identificador)
        {
            //var numTelefonos = personas.Count(p => p.Id.Equals(identificador));
            var persona = personaPorIdentificador(identificador);
            int numTelefonos = (persona.Telefonos != null ? persona.Telefonos.Count() : 0);
            return numTelefonos;
        }

        //EJERCICIO05
        //Método que reciba un identificador y devuelva todas las personas existentes hasta la que
        //tenga un identificador pasado como parámetro.
        public List<Persona> PersonasHastaIdentificador(int identificador, out string msj)
        {
            msj = "";
            var personasHastaIdentificador = from person in personas
                                    where int.Parse(person.Id) <= identificador
                                    select person;
            if (personasHastaIdentificador.Count() < 1)
            {
                msj = "No hay nadie con identificador no superior a " + identificador;
            }

            return personas.ToList();
        }

        //EJERCICIO06
        //Método que devuelve las personas de edad superior o igual a una deseada. Aparecerán
        //ordenadas en orden descendente por edad.
        public List<Persona> PersonasMayorEdad(int edad, out string msj)
        {
            msj = "";
            var personasMayores = from person in personas
                                  where (person.Edad) >= edad
                                  orderby person.Edad descending
                                  select person;
            if (personasMayores.Count() < 1)
            {
                msj = "No hay nadie con edad superior a " + edad;
            }
            return personasMayores.ToList();
        }

        //EJERCICIO07
        //Método que devuelva la o las personas que, siendo menores de edad tienen la máxima edad
        //(entre los menores, se entiende).
        public List<Persona> PersonasMenoresMax(out string msj)
        {
            msj = "";
            var personasMenoresMax = from person in personas
                                     where person.Edad < 18
                                     orderby person.Edad descending
                                     select person;
            if (personasMenoresMax.Count() <1)
            {
                msj = "No hay menores de edad";
            }
            return personasMenoresMax.ToList();
        }

        //EJERCICIO08
        //Modifica el ejercicio anterior, para que, gracias a la creación de un tipo anónimo en el
        //formulario muestre el nombre, edad y cantidad de teléfonos que tienen las personas:
        public IList CantidadTelefonos(out string msj)
        {
            msj = "";
            var personasCantidadTelefonos = from person in personas
                                            where person.Edad < 18
                                            orderby person.Edad descending
                                            select new
                                            {
                                                person.Nombre,
                                                person.Edad,
                                                numTelefonos = (person.Telefonos != null ? person.Telefonos.Count() : 0)
                                            };
            if (personasCantidadTelefonos.Count() < 1)
            {
                msj = "No hay menores de edad";
            }
            return personasCantidadTelefonos.ToList();
        }

        //EJERCICIO09 
        //Método que devuelva las personas que no tienen ningún teléfono, ordenadas por edad
        //(orden descendente).
        public List<Persona> personasSinTelefono(out string msj)
        {
            msj = "";
            var personasSinTelefono = from person in personas
                                     where ((person.Telefonos != null ? person.Telefonos.Count() : 0) <= 0)
                                     orderby person.Edad descending
                                     select person;
            if (personasSinTelefono.Count() < 1)
            {
                msj = "No hay personas sin telefono";
            }
            return personasSinTelefono.ToList();
        }

        //EJERCICIO10
        //Método que devuelva las personas que tienen algún teléfono de más de 9 dígitos.
        public List<Persona> personasTelefonoDigitos(out string msj)
        {
            msj = "";
            var personasTelDigitos = from person in personas
                                     where (person.Telefonos != null && person.Telefonos.Any(tel => tel.Length > 9))
                                     select person;
            if (personasTelDigitos.Count() < 1)
            {
                msj = "No hay personas con telefono de mas de 9 digitos";
            }
            return personasTelDigitos.ToList();
        }

        //EJERCICIO12
        //En el siguiente caso, queremos acceder a las personas que en su nombre tienen un trozo que
        //le pasamos como parámetro, pero para cada persona encontrada, queremos conocer el
        //nombre, edad, localidad, nombre de la provincia, y el primero de sus teléfonos en el caso
        //de que tenga alguno
        public List<Persona> personasLike(string param, out string msj)
        {
            msj = "";
            var personasLike = from person in personas join provin in provincias on
                               person.IdProvincia.ToUpper() equals provin.Id.ToUpper()
                               where person.Nombre.Contains(param)
                               select new
                               {
                                   person.Nombre,
                                   person.Edad,
                                   person.Localidad,
                                   nomProvin = provin.Nombre,
                                   telefono = ((person.Telefonos != null ? person.Telefonos.First() : 0) <= 0)
                               };
            //Me falta crear la clase para devolver lista de ese tipo
            return personasLike.ToList();
        }

    }
}
