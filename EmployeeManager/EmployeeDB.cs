using System;
using System.Collections.Generic;
using System.Data.SQLite;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeManager
{
    public class EmployeeDB
    {
        private String connectionString = "Data Source = employee.db";

        public EmployeeDB()
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            String tableCmd = "CREATE TABLE IF NOT EXISTS empleados(Id INTEGER PRIMARY KEY AUTOINCREMENT, Nombre TEXT, Puesto TEXT, Salario REAL)";
            var cmd = new SQLiteCommand(tableCmd, conn);
            cmd.ExecuteNonQuery();


        }

        public void AddEmp(Employee emp)
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            String query = "INSERT INTO empleados (Nombre, Puesto, Salario) VALUES (@nombre, @puesto, @salario)";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
            cmd.Parameters.AddWithValue("puesto", emp.Puesto);
            cmd.Parameters.AddWithValue("@salario", emp.Salario);
            cmd.ExecuteNonQuery();

        }

        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            String query = "SELECT * FROM empleados";
            var cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                employees.Add(new Employee
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nombre = reader["Nombre"].ToString(),
                    Puesto = reader["Puesto"].ToString(),
                    Salario = Convert.ToDouble(reader["Salario"])
                });
            }

            return employees;
        }

        public void UpdateEmp(Employee emp)
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            var query = "UPDATE empleados SET Nombre = @nombre, Puesto = @puesto, Salario = @salario WHERE Id = @id";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
            cmd.Parameters.AddWithValue("@puesto", emp.Puesto);
            cmd.Parameters.AddWithValue("@salario", emp.Salario);
            cmd.Parameters.AddWithValue("@id", emp.Id);
            cmd.ExecuteNonQuery();
        }

        public void DeleteEmp(int id)
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            var query = "DELETE FROM empleados WHERE Id = @id";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
