using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.CommonData;

namespace UI
{
    public partial class LocalBankA : Form
    {
        private AccountInfo _accountInfo;
        private int _ecnyAmount;
        public LocalBankA(AccountInfo user)
        {
            InitializeComponent();
            _accountInfo = user;
        }

        private async void btn_Buy_Click(object sender, EventArgs e)
        {
            await ClientHelper.BuyInECNY("localbanka", _accountInfo.AccountNumber, textBox_ECNYBuy.Text, "CNY");
            await ClientHelper.GenerateECNY();
            RefreshAmt();
            textBox_ECNYBuy.Text = "";

        }

        private async void btn_Withdraw_Click(object sender, EventArgs e)
        {
            await ClientHelper.WithdrawCNY("localbanka", _accountInfo.AccountNumber, textBox_ECNYBuy.Text);
            RefreshAmt();
            textBox_ECNYBuy.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            PaymentForm form = new PaymentForm(_accountInfo, _ecnyAmount, "localBanka");
            form.ShowDialog();

            RefreshAmt();
        }
        private void btn_History_Click(object sender, EventArgs e)
        {
            History form = new History(_accountInfo, "localbanka");
            form.ShowDialog();
        }
        private void AccountSummary_Load(object sender, EventArgs e)
        {
            ClientHelper.RunAsync();
            label_greeting.Text = "Hello, " + _accountInfo.CustomerID;
            label_CNY.Text = "¥ " + _accountInfo.Balance;
            GetECNYamt(_accountInfo.AccountNumber);
            timer_autoRefresh.Start();
        }

        private async void GetECNYamt(string accountNumber)
        {
            _ecnyAmount = await ClientHelper.GetENCYamount(accountNumber);
            label_ECNY.Text = "¥ " + _ecnyAmount;

        }
        private async void GetCNYamt(string accountNumber)
        {
            _accountInfo = await ClientHelper.GetAccountInfo("localbanka", accountNumber);
            label_CNY.Text = "¥ " + _accountInfo.Balance;
        }

        private void textBox_ECNYBuy_TextChanged(object sender, EventArgs e)
        {
            label_exchangeResult.Text = "¥ " + textBox_ECNYBuy.Text;
        }

        private void RefreshAmt()
        {
            GetECNYamt(_accountInfo.AccountNumber);
            GetCNYamt(_accountInfo.AccountNumber);
            label_CNY.Text = "¥ " + _accountInfo.Balance;
        }

        private void timer_autoRefresh_Tick(object sender, EventArgs e)
        {
            RefreshAmt();
        }
    }
}
