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
    public partial class PaymentForm : Form
    {
        private AccountInfo _accountInfo;
        private int _ecnyAmount;
        private string _bankName;

        public PaymentForm(AccountInfo user, int ecny, string bankName)
        {
            InitializeComponent();
            _accountInfo = user;
            _ecnyAmount = ecny;
            _bankName = bankName;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            label_currentECNY.Text = "current ECNY : ¥ " + _ecnyAmount;
            label_accountNum.Text = "Account Number : " + _accountInfo.AccountNumber;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (comboBox_bank.SelectedIndex < 0)
                MessageBox.Show("Please Select Receiver Bank");

            else
            {
                try
                {
                    callPay();
                    MessageBox.Show("Pay Success!");
                    GetECNYamt();
                    Clear();
                }
                catch
                {

                }
            }

        }

        private async void callPay()
        {

            await ClientHelper.Payment(_bankName, _accountInfo.AccountNumber, textBox_transAmt.Text,
                        comboBox_bank.SelectedItem.ToString(), textBox_receiver.Text);
        }

        private async void GetECNYamt()
        {
            _ecnyAmount = await ClientHelper.GetENCYamount(_accountInfo.AccountNumber);
            label_currentECNY.Text = "current ECNY : ¥ " + _ecnyAmount;

        }


        private void Clear()
        {
            textBox_transAmt.Text = "";
            comboBox_bank.SelectedIndex = -1;
            textBox_receiver.Text = "";
        }
    }
}
