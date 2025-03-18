using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3MarianoTorres
{
    public class Persona
    {
        private string nombre;
        private string email;
        private decimal sueldo;
        private string sexo;
        private decimal peso;
        private decimal altura;

        public Persona(string nombre, decimal sueldo, string sexo, decimal peso, decimal altura)
        {
            this.nombre = nombre;
            this.email = this.CrearEmail();
            this.sueldo = sueldo;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public string GetNombre() => nombre;
        public string GetEmail() => email;
        public decimal GetSueldo() => sueldo;
        public string GetSexo() => sexo;
        public decimal GetPeso() => peso;
        public decimal GetAltura() => altura;


        private string CrearEmail()
        {
            return $"{this.nombre}@superempresa.com";
        }
    }
}
