using PraktijkT8.Model;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace PraktijkT8.Controller
{
    public class ThemaController
    {
        private string connectionString = @"
              Data Source=.\sqlexpress;
              Initial Catalog=SchoolPlanner;
              Integrated Security=True;
              TrustServerCertificate=True";

        /// <summary>
        /// haalt alle themas op uit de database en geeft deze terug als een lijst van ThemaModel objecten
        /// </summary>
        /// <returns> geeft Thema's terug</returns>
        public List<ThemaModel> HaalAlleThemasOp()
        {
            List<ThemaModel> themas = new List<ThemaModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ThemaID, Naam FROM Thema";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        themas.Add(new ThemaModel
                        {
                            ThemaID = (int)reader["ThemaID"],
                            Naam = reader["Naam"].ToString()
                        });
                    }
                }
            }

            return themas;
        }
    }
}