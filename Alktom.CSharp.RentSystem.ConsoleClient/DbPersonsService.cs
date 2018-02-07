using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altkom.CSharp.RentSystem.Models;

namespace Alktom.CSharp.RentSystem.ConsoleClient
{
    public class DbPersonsService : IPersonsService
    {
        const string patternSql = "select top(1) PersonId, FirstName, LastName from dbo.Persons where FirstName = @fullname";

        public void Add(Person person)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=RentDb;Integrated Security=True");

            SqlCommand command = new SqlCommand("INSERT INTO ....", connection);

            command.ExecuteNonQuery();

        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        // Entity Framework / nHibernate, Dapper
        public Person GetByName(string fullname)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=RentDb;Integrated Security=True");

            SqlCommand command = new SqlCommand(patternSql, connection);
            command.Parameters.Add("@fullname", SqlDbType.NVarChar);
            command.Parameters["@fullname"].Value = fullname;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Person person = null;

            if (reader.HasRows)
            {
                reader.Read();

                int personId = reader.GetInt32(0);
                string firstName = reader.GetString(1);

                string lastName = null;

                if (!reader.IsDBNull(2))
                {
                    lastName = reader.GetString(2);

#if DEBUG
                    Console.WriteLine("XXXX");
#endif
                }

                // Wyswietla tylko w trybie DEBUG
                Debug.WriteLine($"{firstName} {lastName}");

                // Wyswietla w trybie DEBUG i RELEASE
                Trace.WriteLine($"{firstName} {lastName}");

                person = new Woman
                {
                    Id = personId,
                    FirstName = firstName,
                    LastName = lastName
                };
            }

            return person;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
