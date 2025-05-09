using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN7TorresMariano
{
    class EmpleadoRepository
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=mariano;Database=empleados_db";

        public List<Empleado> ObtenerTodos()
        {
            var empleados = new List<Empleado>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM empleados";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        empleados.Add(new Empleado
                        {
                            Id = reader.GetInt32(0),
                            NombreCompleto = reader.GetString(1),
                            DNI = reader.GetString(2),
                            Edad = reader.GetInt32(3),
                            Casado = reader.GetBoolean(4),
                            Salario = reader.GetDecimal(5)
                        });
                    }
                }
            }

            return empleados;
        }

        public void AgregarEmpleado(Empleado emp)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO empleados 
                         (nombre_completo, dni, edad, casado, salario)
                         VALUES 
                         (@nombre, @dni, @edad, @casado, @salario)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nombre", emp.NombreCompleto);
                    cmd.Parameters.AddWithValue("dni", emp.DNI);
                    cmd.Parameters.AddWithValue("edad", emp.Edad);
                    cmd.Parameters.AddWithValue("casado", emp.Casado);
                    cmd.Parameters.AddWithValue("salario", emp.Salario);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
