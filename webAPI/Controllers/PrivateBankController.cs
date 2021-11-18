using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using webAPI.DBclass;

namespace webAPI.Controllers
{
    [Route("api/commericalBank")]
    [ApiController]
    public class PrivateBankController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public PrivateBankController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //[HttpGet("/{bankName}/{accountNumber}")]
        //public AccountInfo GetAccountInfo(string bankName, string accountNumber)
        //{

        //    string myDb1ConnectionString = _configuration.GetConnectionString(bankName);
        //    using (MySqlConnection con = new MySqlConnection(myDb1ConnectionString))
        //    {
        //        string query = @"select * from " + bankName + ".accountInfo where accountNumber='" + accountNumber + "'";
        //        using (MySqlCommand cmd = new MySqlCommand(query))
        //        {
        //            cmd.Connection = con;
        //            con.Open();
        //            using (MySqlDataReader sdr = cmd.ExecuteReader())
        //            {

        //                while (sdr.Read())
        //                {
        //                    return new AccountInfo()
        //                    {
        //                        AccountNumber = sdr["accountNumber"].ToString(),
        //                        CustomerID = sdr["customerID"].ToString(),
        //                        Balance = Convert.ToInt32(sdr["balance"])
        //                    };
        //                }
        //            }
        //        }
        //        con.Close();
        //    }

        //    return new AccountInfo()
        //    {
        //        AccountNumber = null
        //    };
        //}


        [HttpPost("/{bankName}/GernerateAccount")]
        public void GernerateAccount(string bankName)
        {
            string myDb1ConnectionString = _configuration.GetConnectionString(bankName);
            string accountLocation = "HK";
            if (!bankName.Contains("local"))
                accountLocation = "TH";
            for (int i = 0; i < 10; i++)
            {
                string query = "INSERT INTO " + bankName + ".accountInfo(accountNumber,balance) VALUES('" + accountLocation + Utilities.RandomNumber() + "',500000) ";
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



        [HttpPost("/{bankName}/WithdrawHKD/{ECNYAmount}")]
        public void WithdrawHKD(double ECNYAmount)
        {
            try
            {
                //check if enough ECNY


                //double moneyNeed = ECNYToHKD(8.2, ECNYAmount);

                //update local transcation
                //update PBOC
                //and balance

            }
            catch (Exception ex)
            {

            }

        }

        [HttpPost("/{bankName}/BuyInECNY/{accountNumber}/{ECNYAmount}")]
        public void BuyInECNY(string bankName, double ECNYAmount, string accountNumber)
        {
            string pBankConnect = _configuration.GetConnectionString(bankName);
            string pbocConnstring = _configuration.GetConnectionString("PBOCCon");
            //insert transcation record and reduce balance
            try
            {
                using (MySqlConnection con = new MySqlConnection(pBankConnect))
                {
                    double amtNeed = 5.1 * ECNYAmount;
                    string query = "INSERT INTO " + bankName + ".conversionrecord (accountNumber, ConvertTime,ConvertAmount,ConvertECNY,Remark) " +
                        "VALUE('" + accountNumber + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'," + ECNYAmount + ", 1 , null) ";
                    con.Open();
                    using (MySqlCommand MyCommand2 = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader MyReader2 = MyCommand2.ExecuteReader())
                        {
                        }
                    }
                    int current = 0;
                    query = "SELECT balance FROM " + bankName + ".accountInfo WHERE accountNumber= '" + accountNumber + "'";
                    using (MySqlCommand MyCommand2 = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader MyReader2 = MyCommand2.ExecuteReader())
                        {

                            while (MyReader2.Read())
                            {
                                current = Convert.ToInt32(MyReader2["balance"]);
                            }
                        }
                    }

                    double finalBalance = current - amtNeed;

                    query = "UPDATE " + bankName + ".accountInfo SET balance =" + finalBalance + " WHERE accountNumber = '" + accountNumber + "'";
                    using (MySqlCommand MyCommand2 = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader MyReader2 = MyCommand2.ExecuteReader())
                        {
                        }
                    }
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //convert ECNY (mark its name)
            try
            {
                using (MySqlConnection con = new MySqlConnection(pbocConnstring))
                {
                    int NumOfECNYNeeded = (int)(ECNYAmount / 1000);
                    string query = "Update pboc.registration Set accountNumber = '" + accountNumber + "' " +
                        "WHERE regID in (SELECT * from(SELECT regID FROM  pboc.registration WHERE accountNumber is NULL limit " + NumOfECNYNeeded + ") as DB1)";
                    MySqlCommand MyCommand2 = new MySqlCommand(query, con);
                    con.Open();
                    using (MySqlDataReader MyReader2 = MyCommand2.ExecuteReader())
                    {
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            //add transcaction record
            try
            {
                using (MySqlConnection con = new MySqlConnection(pbocConnstring))
                {
                    string query = "insert into pboc.transcation(transTime,transAmount,payeeAccNum,receiverAccNum,Remark) " +
                    "Value('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', " + ECNYAmount + ", 'PBOC', '" + accountNumber + "', null)";
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
            catch
            {

            }



        }


        [HttpPost("/{bankName}/WithdrawTHAI/{accountNumber}/{ECNYAmount}")]
        public void WithdrawTHAI(string bankName, double ECNYAmount, string accountNumber)
        {
            string pBankConnect = _configuration.GetConnectionString(bankName);
            string pbocConnstring = _configuration.GetConnectionString("PBOCCon");
            //insert transcation record and reduce balance
            try
            {
                using (MySqlConnection con = new MySqlConnection(pBankConnect))
                {
                    double amtWithdraw = 5.2 * ECNYAmount;
                    string query = "INSERT INTO " + bankName + ".conversionrecord (accountNumber, ConvertTime,ConvertAmount,ConvertECNY,Remark) " +
                        "VALUE('" + accountNumber + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'," + ECNYAmount + ", 0 , null) ";
                    con.Open();
                    using (MySqlCommand MyCommand2 = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader MyReader2 = MyCommand2.ExecuteReader())
                        {
                        }
                    }
                    int current = 0;
                    query = "SELECT balance FROM " + bankName + ".accountInfo WHERE accountNumber= '" + accountNumber + "'";
                    using (MySqlCommand MyCommand2 = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader MyReader2 = MyCommand2.ExecuteReader())
                        {

                            while (MyReader2.Read())
                            {
                                current = Convert.ToInt32(MyReader2["balance"]);
                            }
                        }
                    }

                    double finalBalance = current + amtWithdraw;

                    query = "UPDATE " + bankName + ".accountInfo SET balance =" + finalBalance + " WHERE accountNumber = '" + accountNumber + "'";
                    using (MySqlCommand MyCommand2 = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader MyReader2 = MyCommand2.ExecuteReader())
                        {
                        }
                    }
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //release ECNY (mark its name)
            try
            {
                using (MySqlConnection con = new MySqlConnection(pbocConnstring))
                {
                    int NumOfECNYNeeded = (int)(ECNYAmount / 1000);
                    string query = "Update pboc.registration Set accountNumber = null " +
                        "WHERE regID in (SELECT * from(SELECT regID FROM  pboc.registration WHERE accountNumber ='" + accountNumber + "' limit " + NumOfECNYNeeded + ") as DB1)";
                    MySqlCommand MyCommand2 = new MySqlCommand(query, con);
                    con.Open();
                    using (MySqlDataReader MyReader2 = MyCommand2.ExecuteReader())
                    {
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            //add transcaction record
            try
            {
                using (MySqlConnection con = new MySqlConnection(pbocConnstring))
                {
                    string query = "insert into pboc.transcation(transTime,transAmount,payeeAccNum,receiverAccNum,Remark) " +
                    "Value('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', " + ECNYAmount + " ,'" + accountNumber + "', 'PBOC', null)";
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
            catch
            {

            }



        }

        [HttpPost("/{bankName}/payment/{accountNumber}/{ECNYAmount}/{receiveBank}/{receiveAccount}")]
        public void Payment(string bankName, string receiveBank, double ECNYAmount, string accountNumber, string receiveAccount)
        {
            string pBankConnect = _configuration.GetConnectionString(bankName);
            string pbocConnstring = _configuration.GetConnectionString("PBOCCon");

            //check if 

            //change owernship of ECNY
            try
            {
                using (MySqlConnection con = new MySqlConnection(pbocConnstring))
                {
                    string query = "Update pboc.registration Set accountNumber = '" + receiveAccount + "' " +
                        "WHERE regID in (SELECT * from(SELECT regID FROM  pboc.registration WHERE accountNumber ='" + accountNumber + "' limit " + ECNYAmount + ") as DB1)";
                    MySqlCommand MyCommand2 = new MySqlCommand(query, con);
                    con.Open();
                    using (MySqlDataReader MyReader2 = MyCommand2.ExecuteReader())
                    {
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
            //add transcaction record in POB bank
            try
            {
                using (MySqlConnection con = new MySqlConnection(pbocConnstring))
                {
                    string query = "insert into pboc.transcation(transTime,transAmount,payeeAccNum,receiverAccNum,Remark) " +
                    "Value('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', " + ECNYAmount + ", '" + accountNumber + "', '" + receiveAccount + "', null)";
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
            catch
            {

            }
        }


        private double ECNYToHKD(double exchangeRate, double ECNYamt)
        {
            return ECNYamt * exchangeRate;
        }

        private double HKDToECNY(double exchangeRate, double HKDamt)
        {
            return HKDamt / exchangeRate;
        }
    }
}
