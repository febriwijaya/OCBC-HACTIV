using Asignment3.Models;
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

namespace Asignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        public MovieController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = "select id,name,genre,durations,releasedate from movie";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("MovieAppCon");
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
        public JsonResult Post(Movie emp)
        {
            string query = "insert into movie (name,genre,durations,releasedate) values (@name,@genre,@durations,@releasedate)";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("MovieAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@name", emp.name);
                    myCommand.Parameters.AddWithValue("@genre", emp.genre);
                    myCommand.Parameters.AddWithValue("@durations", emp.durations);
                    myCommand.Parameters.AddWithValue("@releasedate", emp.releasedate);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(Movie emp)
        {
            string query = "update movie set name =@name, genre=@genre, durations=@durations, releasedate=@releasedate where id=@id";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("MovieAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@id", emp.id);
                    myCommand.Parameters.AddWithValue("@name", emp.name);
                    myCommand.Parameters.AddWithValue("@genre", emp.genre);
                    myCommand.Parameters.AddWithValue("@durations", emp.durations);
                    myCommand.Parameters.AddWithValue("@releasedate", emp.releasedate);

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
                        delete from movie 
                        where id=@id;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("MovieAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@id", id);

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
