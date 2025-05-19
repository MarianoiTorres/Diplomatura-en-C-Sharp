using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3MarianoTorres
{
    public class Persona
    {
        private string _nombre;
        private string _email;
        private decimal _sueldo;
        private string _sexo;
        private int _peso;
        private decimal _altura;

        public string Nombre 
        { 
            get => _nombre; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
            
                _nombre = value;
            }

        }
        public string Email { get => _email; private set => _email = value; }
        public decimal Sueldo 
        { 
            get => _sueldo; 
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("El sueldo no puede ser un valor negativo");
                }
                _sueldo = value;
            } 
        }
        public string Sexo 
        { 
            get => _sexo; 
            private set
            {
                string[] sexosPermitidos = { "Masculino", "Femenino" };
                if (!sexosPermitidos.Contains(value))
                {
                    throw new ArgumentException("El sexo debe ser Masculino o Femenino");
                }
                _sexo = value;
            }
        }
        public int Peso
        {
            get => _peso;
            private set
            {
                if (value < 1 || value > 500)
                    throw new ArgumentOutOfRangeException("El peso debe estar entre 1 y 500 kg.");
                _peso = value;
            }
        }
        public decimal Altura
        {
            get => _altura;
            private set
            {
                if (value < 0.5m || value > 2.5m)
                    throw new ArgumentOutOfRangeException("La altura debe ser entre 1,5 y 2,5 cm.");
                _altura = value;
            }
        }
        public Persona(string nombre, decimal sueldo, string sexo, int peso, decimal altura)
        {
            Nombre = nombre;
            Email = CrearEmail();
            Sueldo = sueldo;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
        }

        private string CrearEmail()
        {
            return ($"{Nombre}@superempresa.com").ToLower();
        }
    }
}
