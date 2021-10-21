using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using finalprojects.Models;

namespace finalprojects.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        public PaymentDetailController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = "select * from paymentapi";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("PaymentConn");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }


        [HttpPost]
        public JsonResult Post(PaymentDetail emp)
        {
            string query = @"
                        insert into paymentapi 
                        (cardOwnerName,cardNumber,expirationDate,securityCode) 
                        values
                        (@cardOwnerName,@cardNumber,@expirationDate,@securityCode) ;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("PaymentConn");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@cardOwnerName", emp.cardOwnerName);
                    myCommand.Parameters.AddWithValue("@cardNumber", emp.cardNumber);
                    myCommand.Parameters.AddWithValue("@expirationDate", emp.expirationDate);
                    myCommand.Parameters.AddWithValue("@securityCode", emp.securityCode);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(PaymentDetail emp)
        {
            string query = "update paymentapi set cardOwnerName =@cardOwnerName, cardNumber=@cardNumber, expirationDate=@expirationDate, securityCode=@securityCode where paymentDetailId=@paymentDetailId";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("PaymentConn");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@paymentDetailId", emp.paymentDetailId);
                    myCommand.Parameters.AddWithValue("@cardOwnerName", emp.cardOwnerName);
                    myCommand.Parameters.AddWithValue("@cardNumber", emp.cardNumber);
                    myCommand.Parameters.AddWithValue("@expirationDate", emp.expirationDate);
                    myCommand.Parameters.AddWithValue("@securityCode", emp.securityCode);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }



        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                        delete from paymentapi 
                        where paymentDetailId=@paymentDetailId;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("PaymentConn");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@paymentDetailId", id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }
    }
}
