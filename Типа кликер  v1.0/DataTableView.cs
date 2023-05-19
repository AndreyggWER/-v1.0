using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD=System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Типа_кликер__v1._0
{
    public partial class DataTableView : Form
    {
        public DataTableView()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection();
        public SD.DataSet ds;
        public void OpenC()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseC()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        private void DataTableView_Load(object sender, EventArgs e)
        {
            string Script = RichTextBoxScripter.Text;
            connection = new MySqlConnection(File.ReadAllText("DB.txt"));
            OpenC();
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(Script, GetConnection());
            SD.DataTable Table = new SD.DataTable();
            DataAdapter.Fill(Table);
            DataGridViewOcenki.DataSource = Table;
            CloseC();
        }

        private void ButtonRequest_Click(object sender, EventArgs e)
        {
            string Script = RichTextBoxScripter.Text;
            connection = new MySqlConnection(File.ReadAllText("DB.txt"));
            OpenC();
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(Script, GetConnection());
            SD.DataTable Table = new SD.DataTable();
            DataAdapter.Fill(Table);
            DataGridViewOcenki.DataSource = Table;
            CloseC();
        }
    }
}
