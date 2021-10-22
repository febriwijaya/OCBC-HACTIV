using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Models
{
    public class PaymentContext
    {
        public string ConnectionString { get; set; }

        public PaymentContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<PaymentDetailData> GetPayments()
        {
            List<PaymentDetailData> list = new List<PaymentDetailData>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM PaymentDetail", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PaymentDetailData()
                        {
                            paymentDetailId = reader.GetInt32("paymentDetailId"),
                            cardOwnerName = reader.GetString("cardOwnerName"),
                            cardNumber = reader.GetString("cardNumber"),
                            expirationDate = reader.GetDateTime("expirationDate"),
                            securityCode = reader.GetString("securityCode")
                        });
                    }
                }
            }
            return list;
        }

        public List<PaymentDetailData> GetPayment(string id)
        {
            List<PaymentDetailData> list = new List<PaymentDetailData>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM PaymentDetail WHERE paymentDetailId =@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PaymentDetailData()
                        {
                            paymentDetailId = reader.GetInt32("paymentDetailId"),
                            cardOwnerName = reader.GetString("cardOwnerName"),
                            cardNumber = reader.GetString("cardNumber"),
                            expirationDate = reader.GetDateTime("expirationDate"),
                            securityCode = reader.GetString("securityCode")
                        });
                    }
                }
            }
            return list;
        }
    }
}
