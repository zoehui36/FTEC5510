using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using webAPI.DBclass;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webAPI.Controllers
{
    [Route("api/PBOC")]
    [ApiController]
    public class ECNYController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ECNYController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: api/<ECNYController>
        [HttpGet]
        public JsonResult Get()
        {
            string myDb1ConnectionString = _configuration.GetConnectionString("PBOCCon");
            int result = 0;
            List<Registration> eCNYList = new List<Registration>();
            using (MySqlConnection con = new MySqlConnection(myDb1ConnectionString))
            {
                string query = @"select * from pboc.registration";
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {

                            eCNYList.Add(new Registration
                            {

                                RegistrationID = Convert.ToInt32(sdr["RegID"]),
                                ECNYNumber = sdr["ECNYNumber"].ToString(),
                                AccountNumber = sdr["AccountNumber"].ToString(),
                                Remark = sdr["remark"].ToString()
                            });
                        }
                    }
                    con.Close();
                }

                return new JsonResult(eCNYList);
            }
        }

        // GET api/<ECNYController>/5
        [HttpGet("{accountNumber}")]
        public List<Registration> QueryAccountBalance(string accountNumber)
        {
            List<Registration> resultList = new List<Registration>(); ;
            string myDb1ConnectionString = _configuration.GetConnectionString("PBOCCon");
            string query = "SELECT * FROM pboc.registration WHERE accountNumber='" + accountNumber + "'";
            using (MySqlConnection con = new MySqlConnection(myDb1ConnectionString))
            {
                MySqlCommand MyCommand2 = new MySqlCommand(query, con);

                con.Open();
                using (MySqlDataReader MyReader2 = MyCommand2.ExecuteReader())
                {
                    while (MyReader2.Read())
                    {
                        resultList.Add(new Registration
                        {
                            ECNYNumber = MyReader2["ECNYNumber"].ToString(),
                            AccountNumber = MyReader2["AccountNumber"].ToString(),
                            Remark = MyReader2["remark"].ToString()
                        });
                    }
                }

                con.Close();
            }
            return resultList;
        }

        // POST api/<ECNYController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ECNYController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ECNYController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost("/GernerateECNY")]
        public void GenerateECNY()
        {
            string myDb1ConnectionString = _configuration.GetConnectionString("PBOCCon");

            for (int i = 0; i < 10; i++)
            {
                string query = "INSERT INTO pboc.registration(ECNYNumber) VALUES('" + Utilities.RandomString(8) + "') ";
                using (MySqlConnection con = new MySqlConnection(myDb1ConnectionString))
                {
                    MySqlCommand MyCommand2 = new MySqlCommand(query, con);
                    MySqlDataReader MyReader2;
                    con.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    con.Close();
                }
            }

        }
    }
}
