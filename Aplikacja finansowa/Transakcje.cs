using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AplikacjaFinansowa
{
    public class Transakcja
    {
        public int Id { get; set; }
        public string Typ { get; set; }
        public decimal Kwota { get; set; }
        public DateTime Data { get; set; }
    }

    public class ZarzadzanieTransakcjami
    {
        private string connectionString = "Server = localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        public void DodajTransakcje(Transakcja transakcja)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Transakcje (Typ, Kwota, Data) VALUES (@Typ, @Kwota, @Data)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Typ", transakcja.Typ);
                command.Parameters.AddWithValue("@Kwota", transakcja.Kwota);
                command.Parameters.AddWithValue("@Data", transakcja.Data);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Transakcja> PobierzWszystkieTransakcje()
        {
            List<Transakcja> transakcje = new List<Transakcja>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Typ, Kwota, Data FROM Transakcje";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Transakcja transakcja = new Transakcja();
                    transakcja.Id = Convert.ToInt32(reader["Id"]);
                    transakcja.Typ = reader["Typ"].ToString();
                    transakcja.Kwota = Convert.ToDecimal(reader["Kwota"]);
                    transakcja.Data = Convert.ToDateTime(reader["Data"]);

                    transakcje.Add(transakcja);
                }
            }

            return transakcje;
        }
    }
}
