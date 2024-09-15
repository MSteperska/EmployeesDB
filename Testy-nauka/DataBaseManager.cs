using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Testy_nauka
{
    public class DataBaseManager
    {
        private string connectionString;

        public DataBaseManager(string dbPath)
        {
            // Ustawienie connection string do bazy danych SQLite
            connectionString = $"Data Source={"C:\\Gocha\\Studia\\6\\XPW\\2\\DBLearning\\Testy-nauka\\EmployeesDB.db"}";
        }

        // Metoda do pobierania wszystkich pracowników z bazy danych
        public List<Person> GetAllEmployees(List<Person> employees)
        {
            //List<Person> employees = new List<Person>();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Employee";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Odczyt i parsowanie danych
                            string dateString = reader.GetString(2);
                            DateTime birthdate;
                            bool success = DateTime.TryParse(dateString, out birthdate);
                            if (!success)
                            {
                                Console.WriteLine("Invalid date format in database");
                                continue; // Pomija, jeśli format daty jest niepoprawny
                            }

                            // Tworzenie obiektu Person
                            Person person = new Person
                            {
                                name = reader["name"].ToString(),
                                surname = reader["surname"].ToString(),
                                birthdate = Convert.ToDateTime(reader["birthdate"]),
                                position = reader["position"].ToString(),
                                salary = reader["salary"].ToString(),
                                bonus = reader["bonus"].ToString(),
                                email = reader["email"].ToString(),
                                phone = reader["phone"].ToString(),
                                budget = reader.IsDBNull(8) ? null : reader.GetString(8),
                                department = reader.IsDBNull(9) ? null : reader.GetString(9),
                                teamsize = reader.IsDBNull(10) ? null : reader.GetString(10),
                                programminglanguages = reader.IsDBNull(11) ? null : reader.GetString(11),
                                github = reader.IsDBNull(12) ? null : reader.GetString(12),
                                comissionrate = reader.IsDBNull(13) ? null : reader.GetString(13),
                                keyaccounts = reader.IsDBNull(14) ? null : reader.GetString(14),
                                supportedsystems = reader.IsDBNull(15) ? null : reader.GetString(15),
                                ticketsresolved = reader.IsDBNull(16) ? null : reader.GetString(16),
                                campaignsmanaged = reader.IsDBNull(17) ? null : reader.GetString(17),
                                digitalmaketingskills = reader.IsDBNull(18) ? null : reader.GetString(18),
                            };

                            employees.Add(person);
                        }
                    }
                }
            }

            return employees;
        }

        // Metoda do dodawania nowego pracownika do bazy danych
        public void AddEmployee(Person person)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Employee (name, surname, birthdate, position, salary, bonus, email, phone, budget, department, teamsize, programminglanguages, github, comissionrate, keyaccounts, supportedsystems, ticketsresolved, campaignsmanaged, digitalmarketingskills) " +
                               "VALUES (@name, @surname, @birthdate, @position, @salary, @bonus, @email, @phone, @budget, @department, @teamsize, @programminglanguages, @github, @comissionrate, @keyaccounts, @supportedsystems, @ticketsresolved, @campaignsmanaged, @digitalmarketingskills)";

                using (var command = new SqliteCommand(query, connection))
                {
                    // Dodawanie parametrów SQL
                    command.Parameters.AddWithValue("@name", person.name);
                    command.Parameters.AddWithValue("@surname", person.surname);
                    command.Parameters.AddWithValue("@birthdate", person.birthdate.ToString("yyyy-MM-dd")); // format daty
                    command.Parameters.AddWithValue("@position", person.position);
                    command.Parameters.AddWithValue("@salary", person.salary);
                    command.Parameters.AddWithValue("@bonus", person.bonus);
                    command.Parameters.AddWithValue("@email", person.email);
                    command.Parameters.AddWithValue("@phone", person.phone);
                    command.Parameters.AddWithValue("@budget", string.IsNullOrEmpty(person.budget) ? (object)DBNull.Value : person.budget);
                    command.Parameters.AddWithValue("@department", string.IsNullOrEmpty(person.department) ? (object)DBNull.Value : person.department);
                    command.Parameters.AddWithValue("@teamsize", string.IsNullOrEmpty(person.teamsize) ? (object)DBNull.Value : person.teamsize);
                    command.Parameters.AddWithValue("@programminglanguages", string.IsNullOrEmpty(person.programminglanguages) ? (object)DBNull.Value : person.programminglanguages);
                    command.Parameters.AddWithValue("@github", string.IsNullOrEmpty(person.github) ? (object)DBNull.Value : person.github);
                    command.Parameters.AddWithValue("@comissionrate", string.IsNullOrEmpty(person.comissionrate) ? (object)DBNull.Value : person.comissionrate);
                    command.Parameters.AddWithValue("@keyaccounts", string.IsNullOrEmpty(person.keyaccounts) ? (object)DBNull.Value : person.keyaccounts);
                    command.Parameters.AddWithValue("@supportedsystems", string.IsNullOrEmpty(person.supportedsystems) ? (object)DBNull.Value : person.supportedsystems);
                    command.Parameters.AddWithValue("@ticketsresolved", string.IsNullOrEmpty(person.ticketsresolved) ? (object)DBNull.Value : person.ticketsresolved);
                    command.Parameters.AddWithValue("@campaignsmanaged", string.IsNullOrEmpty(person.campaignsmanaged) ? (object)DBNull.Value : person.campaignsmanaged);
                    command.Parameters.AddWithValue("@digitalmarketingskills", string.IsNullOrEmpty(person.digitalmaketingskills) ? (object)DBNull.Value : person.digitalmaketingskills);

                    // Wykonanie zapytania INSERT
                    command.ExecuteNonQuery();
                }
            }
        }

        /*private string connectionString;
        public DataBaseManager(string dbPath)
        {
            connectionString = $"Data Source = {dbPath}";
        }

        public List<Person> GetAllEmployees()
        {
            List<Person> employees = new List<Person>();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Employee";
                using (var command = new SqliteCommand(query, connection))
                {
                    // Wykonanie zapytania
                    //var result = command.ExecuteScalar();

                    // Wyświetlenie wyniku zapytania
                   // Console.WriteLine($"Liczba tabel w bazie danych: {result}");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dateString = reader.GetString(2);
                            DateTime birthdate;
                            bool success = DateTime.TryParse(dateString, out birthdate);
                            if (success)
                            {
                                Console.WriteLine($"Birthdate: {birthdate.Date.ToString("dd-MM-yyyy HH:mm:ss")}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid date format in database");
                            }
                            //dodanie zabezpieczenia gdy jakieś wartości są nullami


                            Person person = new Person
                            {
                                
                                name = reader.GetString(0),
                                surname = reader.GetString(1),
                                birthdate = birthdate,
                                position = reader.GetString(3),
                                salary = reader.GetString(4),
                                bonus = reader.GetString(5),
                                email = reader.GetString(6),
                                phone = reader.GetString(7),
                                budget = reader.IsDBNull(8) ? null : reader.GetString(8),
                                department = reader.IsDBNull(9) ? null : reader.GetString(9),
                                teamsize = reader.IsDBNull(10) ? null : reader.GetString(10),
                                programminglanguages = reader.IsDBNull(11) ? null : reader.GetString(11),
                                github = reader.IsDBNull(12) ? null : reader.GetString(12),
                                comissionrate = reader.IsDBNull(13) ? null : reader.GetString(13),
                                keyaccounts = reader.IsDBNull(14) ? null : reader.GetString(14),
                                supportedsystems = reader.IsDBNull(15) ? null : reader.GetString(15),
                                ticketsresolved = reader.IsDBNull(16) ? null : reader.GetString(16),
                                campaignsmanaged = reader.IsDBNull(17) ? null : reader.GetString(17),
                                digitalmaketingskills = reader.IsDBNull(18) ? null : reader.GetString(18),


                            };
                            employees.Add(person);
                        }
                    }
                }
            }

        return employees;

        }

        //miejsce na inne metody do obsługi CRUD
        */

    }
}
