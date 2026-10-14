using Microsoft.Data.SqlClient;
using PraktijkT8.Model;
using System.Collections.Generic;

namespace PraktijkT8.Controller
{
    public class ModuleController
    {
        private string connectionString =
            @"Data Source=(local)\SQLEXPRESS;
              Initial Catalog=SchoolPlanner;
              Integrated Security=True;
              TrustServerCertificate=True";
       
        public List<ModuleModel> GetModules(int themaID)
        {
            List<ModuleModel> modules =
                new List<ModuleModel>();

            using (SqlConnection connection =
                new SqlConnection(connectionString))

            {
                connection.Open();     

                string query =          /// haalt alle modules op die bij een bepaald thema horen, inclusief de naam van het thema en de gegevens van de docent
                    @"SELECT
                          Module.ModuleID,
                          Module.Naam,
                          Module.ThemaID,
                          Module.DocentID,

                          Thema.Naam AS ThemaNaam,

                          Docent.Voornaam AS DocentVoornaam,
                          Docent.Achternaam AS DocentAchternaam,
                          Docent.Tussenvoegsel,
                          Docent.Afbeelding

                      FROM Module

                      INNER JOIN Thema
                          ON Module.ThemaID = Thema.ThemaID

                      INNER JOIN Docent
                          ON Module.DocentID = Docent.DocentID

                      WHERE Module.ThemaID = @ThemaID";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@ThemaID", themaID);

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())       /// leest alle modules die bij het opgegeven themaID horen en voegt ze toe aan de lijst van modules
                        {
                            modules.Add(new ModuleModel
                            {
                                ModuleID =
                                (int)reader["ModuleID"],

                                Naam =
                                reader["Naam"].ToString(),

                                ThemaID =
                                (int)reader["ThemaID"],

                                DocentID =
                                (int)reader["DocentID"],

                                ThemaNaam =
                                reader["ThemaNaam"].ToString(),

                                DocentVoornaam =
                                reader["DocentVoornaam"].ToString(),

                                DocentAchternaam =
                                reader["DocentAchternaam"].ToString(),

                                Tussenvoegsel =
                                reader["Tussenvoegsel"].ToString(),

                                Afbeelding =
                                reader["Afbeelding"].ToString()
                            });
                        }
                    }
                }
            }

            return modules;
        }

        /// <summary>
        /// verwijderd een module en alle bijbehorende taken uit de database
        /// </summary>
        /// <param name="moduleID"></param>
        public void VerwijderModule(int moduleID)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string verwijderTaken =
                    "DELETE FROM Taak WHERE ModuleID = @ModuleID";

                using (SqlCommand command =
                    new SqlCommand(verwijderTaken, connection))
                {
                    command.Parameters.AddWithValue(
                        "@ModuleID", moduleID);

                    command.ExecuteNonQuery();
                }

                string verwijderModule =
                    "DELETE FROM Module WHERE ModuleID = @ModuleID";

                using (SqlCommand command =
                    new SqlCommand(verwijderModule, connection))
                {
                    command.Parameters.AddWithValue(
                        "@ModuleID", moduleID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}