using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.CommonData;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string userName = textBox_userName.Text;
                await ClientHelper.RunAsync();
                AccountInfo user;
                if (textBox_userName.Text.ToUpper().Contains("HK"))
                    user = await ClientHelper.GetAccountInfo("localbanka", userName);
                else
                    user = await ClientHelper.GetAccountInfo("thaibankb", userName);

                if (user.AccountNumber == null)
                    MessageBox.Show("Account Not Found");
                else
                {
                    this.Hide();
                    if (textBox_userName.Text.ToUpper().Contains("HK"))
                    {
                        LocalBankA form2 = new LocalBankA(user);
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                    else
                    {
                        ThaiBankB form3 = new ThaiBankB(user);
                        form3.Closed += (s, args) => this.Close();
                        form3.Show();
                    }

                }
            }
            catch (Exception ex)
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
