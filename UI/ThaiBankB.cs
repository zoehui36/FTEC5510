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
    public partial class ThaiBankB : Form
    {
        private AccountInfo _accountInfo;
        private int _ecnyAmount;
        private decimal _exRate = 0;
        public ThaiBankB(AccountInfo user)
        {
            InitializeComponent();
            _accountInfo = user;
        }

        private async void btn_Buy_Click(object sender, EventArgs e)
        {
            await ClientHelper.BuyInECNY("thaibankb", _accountInfo.AccountNumber, textBox_ECNYBuy.Text, "THB");
            await ClientHelper.GenerateECNY();
            RefreshAmt();
            textBox_ECNYBuy.Text = "";
        }

        private async void btn_Withdraw_Click(object sender, EventArgs e)
        {
            await ClientHelper.WithdrawTHB("thaibankb", _accountInfo.AccountNumber, textBox_ECNYBuy.Text);
            RefreshAmt();
            textBox_ECNYBuy.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            PaymentForm form = new PaymentForm(_accountInfo, _ecnyAmount, "thaibankb");
            form.ShowDialog();

            RefreshAmt();
        }
        private void btn_History_Click(object sender, EventArgs e)
        {
            History form = new History(_accountInfo, "thaibankb");
            form.ShowDialog();
        }
        private void RefreshAmt()
        {
            GetECNYamt(_accountInfo.AccountNumber);
            GetTHBamt(_accountInfo.AccountNumber);
            label_THB.Text = " ฿ " + _accountInfo.Balance;
        }

        private async void GetECNYamt(string accountNumber)
        {
            _ecnyAmount = await ClientHelper.GetENCYamount(accountNumber);
            label_ECNY.Text = "¥ " + _ecnyAmount;

        }
        private async void GetTHBamt(string accountNumber)
        {
            _accountInfo = await ClientHelper.GetAccountInfo("thaibankb", accountNumber);
            label_THB.Text = " ฿ " + _accountInfo.Balance;
        }

        private async void GetExchangeRate()
        {

            if (_exRate == 0)
            {
                _exRate = await ClientHelper.GetExchangeRate();

            }
            label_exRate.Text = _exRate.ToString();
        }

        private void ThaiBankB_Load(object sender, EventArgs e)
        {
            ClientHelper.RunAsync();
            label_greeting.Text = "Hello, " + _accountInfo.CustomerID;
            label_THB.Text = " ฿ " + _accountInfo.Balance;
            GetECNYamt(_accountInfo.AccountNumber);
            GetExchangeRate();
            timer_autoRefresh.Start();


        }

        private void textBox_ECNYBuy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ECNYBuy.Text))
                label_exchangeResult.Text = " ฿ 0";

            else
            {
                decimal r = Convert.ToDecimal(textBox_ECNYBuy.Text) * _exRate;
                label_exchangeResult.Text = " ฿ " + r.ToString();
            }
        }

        private void timer_autoRefresh_Tick(object sender, EventArgs e)
        {
            RefreshAmt();
        }
    }
}
