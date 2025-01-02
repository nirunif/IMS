using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using IMSProject.Models;
using Microsoft.Data.SqlClient;

namespace IMSProject.Data
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public T QuerySingle<T>(string query, object parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                return connection.QuerySingleOrDefault<T>(query, parameters);
            }
        }

        public IEnumerable<T> Query<T>(string query, object parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                return connection.Query<T>(query, parameters);
            }
        }

        public int Execute(string query, object parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                return connection.Execute(query, parameters);
            }
        }

        public T ExecuteScalar<T>(string query, object parameters = null)
        {
            using (var connection = new SqlConnection("Data Source=N1RUN1F;Initial Catalog=IMSdb;Integrated Security=True; TrustServerCertificate=True;"))
            {
                var command = new SqlCommand(query, connection);

                // Ensure parameters is treated as a Dictionary<string, object>
                if (parameters != null && parameters is IDictionary<string, object> parameterDict)
                {
                    foreach (var param in parameterDict)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }
                }

                connection.Open();
                var result = command.ExecuteScalar();

                // Safely cast the result to the specified type (T)
                if (result != null && result != DBNull.Value)
                {
                    return (T)Convert.ChangeType(result, typeof(T));
                }
                return default;
            }
        }


        public T ExecuteReader<T>(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = new SqlConnection("Data Source=N1RUN1F;Initial Catalog=IMSdb;Integrated Security=True; TrustServerCertificate=True;"))
            {
                var command = new SqlCommand(query, connection);

                // Add parameters to the command if any
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                connection.Open();

                // Execute the query and return the result
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Map the result to the target object (e.g., Patient)
                        var patient = new Patient
                        {
                            PatientID = reader.GetInt32(reader.GetOrdinal("PatientID")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Address = reader.GetString(reader.GetOrdinal("Address")),
                            ContactNumber = reader.GetString(reader.GetOrdinal("ContactNumber")),
                            DateofBirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth")),
                            MedicalCondition = reader.GetString(reader.GetOrdinal("MedicalCondition")),
                            Diagnosis = reader.GetString(reader.GetOrdinal("Diagnosis")),
                            TotalCost = reader.GetDecimal(reader.GetOrdinal("TotalCost"))
                        };
                        return (T)(object)patient;
                    }
                    else
                    {
                        return default; // Return default if no rows are found
                    }
                }
            }
        }


        public IEnumerable<T> ExecuteQuery<T>(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.Query<T>(sql, parameters);
            }
        }


        //public List<T> ExecuteQuery<T>(string query) where T : new()
        //{
        //    var result = new List<T>();

        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        var command = new SqlCommand(query, connection);
        //        connection.Open();

        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var item = new T();
        //                foreach (var prop in typeof(T).GetProperties())
        //                {
        //                    if (!Equals(reader[prop.Name], DBNull.Value))
        //                    {
        //                        prop.SetValue(item, reader[prop.Name]);
        //                    }
        //                }
        //                result.Add(item);
        //            }
        //        }
        //    }

        //    return result;
        //}


        //public List<T> ExecuteQuery<T>(string query) where T : new()
        //{
        //    var result = new List<T>();

        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        var command = new SqlCommand(query, connection);
        //        connection.Open();

        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var item = new T();
        //                foreach (var prop in typeof(T).GetProperties())
        //                {
        //                    if (!Equals(reader[prop.Name], DBNull.Value))
        //                    {
        //                        prop.SetValue(item, reader[prop.Name]);
        //                    }
        //                }
        //                result.Add(item);
        //            }
        //        }
        //    }

        //    return result;
        //}

        public List<PatientWithImages> ExecutePatientWithImagesQuery(string query)
        {
            var result = new List<PatientWithImages>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    var patientDictionary = new Dictionary<int, PatientWithImages>();

                    while (reader.Read())
                    {
                        int patientId = (int)reader["PatientID"];

                        // Check if the patient already exists in the dictionary
                        if (!patientDictionary.TryGetValue(patientId, out var patient))
                        {
                            patient = new PatientWithImages
                            {
                                PatientID = patientId,
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                DateofBirth = (DateTime)reader["DateofBirth"],
                                MedicalCondition = reader["MedicalCondition"].ToString(),
                                Diagnosis = reader["Diagnosis"].ToString(),
                                TotalCost = (decimal)reader["TotalCost"],
                                MedicalStaffID = (int)reader["MedicalStaffID"],
                                MedicalImages = new List<MedicalImages>()
                            };

                            patientDictionary.Add(patientId, patient);
                        }

                        // Add medical image details if available
                        if (!reader.IsDBNull(reader.GetOrdinal("ImageID")))
                        {
                            var medicalImage = new MedicalImages
                            {
                                ImageID = (int)reader["ImageID"],
                                ImageType = reader["ImageType"].ToString(),
                                DiseaseType = reader["DiseaseType"].ToString(),
                                ImageURL = reader["ImageURL"].ToString(),
                                UploadDate = (DateTime)reader["UploadDate"]
                            };
                            patient.MedicalImages.Add(medicalImage);
                        }
                    }

                    result = patientDictionary.Values.ToList();
                }
            }

            return result;
        }






    }
}
