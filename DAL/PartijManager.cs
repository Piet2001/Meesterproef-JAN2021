using System;
using System.Collections.Generic;
using System.Diagnostics;
using Interfaces.Dal;
using Interfaces.DTO;
using Interfaces.Logic;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class PartijManager : IPartijManager
    {
        private readonly string _connectionString;
        
        public PartijManager(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<PartijDto> GetAllePartijen()
        {
            List<PartijDto> partijen = new List<PartijDto>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                using (MySqlCommand query = new MySqlCommand("SELECT orde, naam, lijsttrekker FROM partij Order by orde", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        var partij = new PartijDto();
                        {
                            partij.Orde = reader.GetString(0);
                            partij.Naam = reader.GetString(1);
                            partij.Lijsttrekker = reader.GetString(2);
                        }
                        partijen.Add(partij);
                    }
                }
            }
            return partijen;
        }
        public bool PartijToevoegen(IPartij partij)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    var query = conn.CreateCommand();
                    conn.Open();
                    query.CommandText =
                        @"INSERT INTO `coalitievormer`.`partij` (`Orde`, `Naam`, `Lijsttrekker`) VALUES (@Orde, @Naam, @Lijsttrekker);";
                    query.Parameters.AddWithValue("Orde", partij.Orde);
                    query.Parameters.AddWithValue("Naam", partij.Naam);
                    query.Parameters.AddWithValue("Lijsttrekker", partij.Lijsttrekker);
                    query.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }

            return true;
        }

        public bool UpdatePartij(IPartij partij)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    var query = conn.CreateCommand();
                    conn.Open();
                    query.CommandText =
                        @"UPDATE `coalitievormer`.`partij` SET `Lijsttrekker`=@Lijsttrekker WHERE  `Orde`=@Orde;";
                    query.Parameters.AddWithValue("Orde", partij.Orde);
                    query.Parameters.AddWithValue("Lijsttrekker", partij.Lijsttrekker);
                    query.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }

            return true;
        }
    }
}
