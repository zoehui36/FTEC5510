using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOCUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=localhost;port=3306;Initial Catalog=pboc;User Id=root;Password='P@ssw0rd';";
            string queryBelong = "SELECT * FROM pboc.registration";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(queryBelong, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = ds.Tables[0];
                    dataGridView_belong.DataSource = bindingSource;
                }
            }

            string queryTrans = "SELECT * FROM pboc.transcation;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(queryTrans, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = ds.Tables[0];
                    dataGridView_transcation.DataSource = bindingSource;
                }
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            string connStr = "Data Source=localhost;port=3306;Initial Catalog=pboc;User Id=root;Password='P@ssw0rd';";
            string queryBelong = "SELECT * FROM pboc.registration";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(queryBelong, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = ds.Tables[0];
                    dataGridView_belong.DataSource = bindingSource;
                }
            }

            string queryTrans = "SELECT * FROM pboc.transcation;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(queryTrans, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = ds.Tables[0];
                    dataGridView_transcation.DataSource = bindingSource;
                }
            }

        }
    }
}
