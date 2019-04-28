using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcAfternoonB.Models
{
    public class Person
    {
        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Db"].ToString();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public string Phone { get; set; }

        public static List<Person> GetListPerson()
        {
            return new List<Person> {
                new Person{Id=1,Name="Ahmed",Addres="Goljano",Phone="5555"},
                new Person{Id=1,Name="Ahmed",Addres="Goljano",Phone="5555"},
                new Person{Id=1,Name="Ahmed",Addres="Goljano",Phone="5555"},
                new Person{Id=1,Name="Ahmed",Addres="Goljano",Phone="5555"},
                new Person{Id=1,Name="Ahmed",Addres="Goljano",Phone="5555"},
                new Person{Id=1,Name="Ahmed",Addres="Goljano",Phone="5555"},
                new Person{Id=1,Name="Ahmed",Addres="Goljano",Phone="5555"},
                new Person{Id=1,Name="Ahmed",Addres="Goljano",Phone="5555"},
                new Person{Id=1,Name="Ahmed",Addres="Goljano",Phone="5555"},
            };
        }

        public static void CreatePerson(Person person)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Persons VALUES (@Name,@Addres,@Phone)";
                cmd.Parameters.AddWithValue("@Name", person.Name);
                cmd.Parameters.AddWithValue("@Addres", person.Addres);
                cmd.Parameters.AddWithValue("@Phone", person.Phone);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}