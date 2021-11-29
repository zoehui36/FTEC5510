using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using UI.CommonData;

namespace UI
{
    public partial class History : Form
    {
        private AccountInfo _accountInfo;
        private string _bankName;
        public History(AccountInfo account, string bankName)
        {
            InitializeComponent();
            _accountInfo = account;
            _bankName = bankName;
        }

        private void History_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=localhost;port=3306;Initial Catalog=" + _bankName + ";User Id=root;Password='P@ssw0rd';";
            string query = "SELECT convertTime, convertAmount, IF(ConvertECNY=1, 'Buy in', 'Withdraw') as ECNY FROM "
                + _bankName + ".conversionrecord WHERE accountNumber = '" + _accountInfo.AccountNumber + "'";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = ds.Tables[0];
                    dataGridView1.DataSource = bindingSource;
                }
            }
        }
    }
}
