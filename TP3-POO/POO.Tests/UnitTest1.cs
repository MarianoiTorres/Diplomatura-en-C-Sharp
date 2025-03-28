using TP3MarianoTorres;

namespace POO.Tests
{
    public class PersonaTest
    {
        // validacion de que el objeto se creo
        [Fact]
        public void CrearPersona()
        {
            var persona = new Persona("Mariano", Convert.ToDecimal(100.50), "Masculino", 75, 1.75m);

            Assert.NotNull(persona);
        }

        // validacion de que las propiedades se crearon correctamente
        [Fact]
        public void PropiedadesCorrectas()
        {
            var persona = new Persona("Lucia", 40000, "Femenino", 55, 1.60m);

            Assert.Equal("Lucia", persona.Nombre);
            Assert.Equal("lucia@superempresa.com", persona.Email); // Verifica que el email este en minusculas
            Assert.Equal(40000, persona.Sueldo);
            Assert.Equal("Femenino", persona.Sexo);
            Assert.Equal(55, persona.Peso);
            Assert.Equal(1.60m, persona.Altura);
        }

        // validacion de que el metodo crear email funciona correctamente 
        [Fact]
        public void EmailGeneradoCorrectamente()
        {
            var persona = new Persona("Carlos", 50000, "Masculino", 80, 1.80m);
            Assert.Equal("carlos@superempresa.com", persona.Email);
        }

        // validar que no se repita el email y que por lo tanto cada persona sea unica
        [Fact]
        public void UnicidadPersonas()
        {
            var persona1 = new Persona("Mariano", Convert.ToDecimal(100.50), "Masculino", 75, 1.75m);
            var persona2 = new Persona("Ignacio", Convert.ToDecimal(100.50), "Masculino", 75, 1.75m);

            Assert.NotEqual(persona1.Email, persona2.Email);
        }

    }
}
