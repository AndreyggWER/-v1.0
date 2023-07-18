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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Типа_кликер__v1._0
{
    public partial class DataTableView : Form
    {
        public DataTableView()
        {
            DataInProgramm.ClickDetails = "0";
            InitializeComponent();
            TextBoxYear.Text = DateTime.Now.Year.ToString();
            TextBoxQuart.Text = "1";
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

        private void LoadData()
        {
            if (TextBoxNameBaby.Text != "")
                DataInProgramm.Script += " AND child='" + TextBoxNameBaby.Text + "'";
            if (TextBoxQuart.Text != "")
                DataInProgramm.Script += " AND quarter='" + TextBoxQuart.Text + "'";
            if (TextBoxYear.Text != "")
                DataInProgramm.Script += " AND year='" + TextBoxYear.Text + "'";
            connection = new MySqlConnection(File.ReadAllText("DB.txt"));
            OpenC();
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(DataInProgramm.Script, GetConnection());
            SD.DataTable Table = new SD.DataTable();
            DataAdapter.Fill(Table);
            DataGridViewOcenki.DataSource = Table;
            CloseC();
        }

        private void DataTableView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ButtonRequest_Click(object sender, EventArgs e)
        {
            DataInProgramm.Script = RichTextBoxScripter.Text;
            LoadData();
        }

        private void TextBoxYear_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TextBoxQuart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(TextBoxQuart.Text);
                if (Convert.ToInt32(TextBoxQuart.Text) > 4)
                {
                    TextBoxQuart.Text = 4.ToString();
                }
                if (Convert.ToInt32(TextBoxQuart.Text) < 1)
                {
                    TextBoxQuart.Text = 1.ToString();
                }
            }
            catch (FormatException)
            {
                Convert.ToString(TextBoxQuart.Text);
            }
            LoadData();
        }

        private void TextBoxNameBaby_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ButtonYearPlus_Click_1(object sender, EventArgs e)
        {
            TextBoxYear.Text = Convert.ToString(Convert.ToInt32(TextBoxYear.Text) + 1);
        }

        private void ButtonYearMinus_Click_1(object sender, EventArgs e)
        {
            TextBoxYear.Text = Convert.ToString(Convert.ToInt32(TextBoxYear.Text) - 1);
        }
        private void ButtonQuartMinus_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextBoxQuart.Text) <= 3)
            {
                TextBoxQuart.Text = Convert.ToString(Convert.ToInt32(TextBoxQuart.Text) + 1);
            }
        }

        private void ButtonQuartPlus_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextBoxQuart.Text) >= 2)
            {
                TextBoxQuart.Text = Convert.ToString(Convert.ToInt32(TextBoxQuart.Text) - 1);
            }
        }

        private void DataGridViewOcenki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow SlctRow = DataGridViewOcenki.Rows[index];

            DataInProgramm.CodeDetails = SlctRow.Cells[0].Value.ToString();
            DataInProgramm.YearDetails = SlctRow.Cells[1].Value.ToString();
            DataInProgramm.QuarterDetails = SlctRow.Cells[2].Value.ToString();
            DataInProgramm.ChildDetails = SlctRow.Cells[3].Value.ToString();
            DataInProgramm.SubjectDetails = SlctRow.Cells[4].Value.ToString();
            DataInProgramm.GradesDetails = SlctRow.Cells[5].Value.ToString();
            DataInProgramm.PointsDetails = SlctRow.Cells[6].Value.ToString();
        }

        private void ButtonDetails_Click(object sender, EventArgs e)
        {
            DataInProgramm.ClickDetails = "1";
            this.Close();
        }

        private void RichTextBoxScripter_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewOcenki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
