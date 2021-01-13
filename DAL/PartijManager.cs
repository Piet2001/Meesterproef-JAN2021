using System.Collections.Generic;
using Interfaces.Dal;
using Interfaces.DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class PartijManager : IPartijManager
    {
        private readonly string _connectionString = "Connectionstring";

        public List<PartijDTO> GetAllePartijen()
        {
            List<PartijDTO> Partijen = new List<PartijDTO>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                using (MySqlCommand query = new MySqlCommand("SELECT orde, naam, lijsttrekker FROM partij Order by orde", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        var partij = new PartijDTO();
                        {
                            partij.Orde = reader.GetString(0);
                            partij.Naam = reader.GetString(1);
                            partij.Lijsttrekker = reader.GetString(2);
                        }
                        Partijen.Add(partij);
                    }
                }
            }
            return Partijen;
        }

    }
}
