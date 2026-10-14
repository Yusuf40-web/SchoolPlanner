using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using PraktijkT8.Model;

namespace PraktijkT8.Controller
{
    
    public class TaakController
    {
        private string connectionString = @"
              Data Source=.\sqlexpress;
              Initial Catalog=SchoolPlanner;
              Integrated Security=True;
              TrustServerCertificate=True";


       
        public List<TaakModel> GetTaken(int moduleID)
        {
            List<TaakModel> taken =
                new List<TaakModel>();

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query =
                    @"SELECT *
                      FROM Taak
                      WHERE ModuleID = @ModuleID";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@ModuleID", moduleID);

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            taken.Add(new TaakModel
                            {
                                TaakID =
                                    (int)reader["TaakID"],

                                Naam =
                                    reader["Naam"].ToString(),

                                Omschrijving =
                                    reader["Omschrijving"].ToString(),

                                StartDatum =
                                    (DateTime)reader["StartDatum"],

                                Inleverdatum =
                                    (DateTime)reader["Inleverdatum"],

                                Status =
                                    reader["Status"].ToString(),

                                ModuleID =
                                    (int)reader["ModuleID"]
                            });
                        }
                    }
                }
            }

            return taken;
        }

        /// <summary>
        /// verwijdert een taak uit de database op basis van het opgegeven taakID
        /// </summary>
        /// <param name="taakID"></param>
        public void VerwijderTaak(int taakID)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query =
                    "DELETE FROM Taak WHERE TaakID = @TaakID";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaakID", taakID);

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// voegt een nieuwe taak toe aan de database met behulp van de gegevens van het opgegeven TaakModel-object
        /// </summary>
        /// <param name="taak"></param>

        public void VoegTaak(TaakModel taak)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query =
                    @"INSERT INTO Taak
              (Naam, Omschrijving, StartDatum, Inleverdatum, Status, ModuleID)
              VALUES
              (@Naam, @Omschrijving, @StartDatum, @Inleverdatum, @Status, @ModuleID)";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Naam", taak.Naam);
                    command.Parameters.AddWithValue("@Omschrijving", taak.Omschrijving);
                    command.Parameters.AddWithValue("@StartDatum", taak.StartDatum);
                    command.Parameters.AddWithValue("@Inleverdatum", taak.Inleverdatum);
                    command.Parameters.AddWithValue("@Status", taak.Status);
                    command.Parameters.AddWithValue("@ModuleID", taak.ModuleID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}