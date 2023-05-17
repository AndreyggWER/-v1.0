using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Типа_кликер__v1._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        readonly MySqlConnection Lconnection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=loginandreg");

        public void LOpenC()
        {
            if (Lconnection.State == System.Data.ConnectionState.Closed)
            {
                Lconnection.Open();
            }
        }
        public void LCloseC()
        {
            if (Lconnection.State == System.Data.ConnectionState.Open)
            {
                Lconnection.Close();
            }
        }
        public MySqlConnection GetLconnection()
        {
            return Lconnection;
        }
        public Boolean CheckUser()
        {

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SElECT * FROM `users` WHERE `login` = @Login", GetLconnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = TextBoxUserName.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт с таким логином уже существует, введите другой");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string Login = TextBoxUserName.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SElECT * FROM `users` WHERE `login` = Login AND `password` = Password", GetLconnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы вошли");
                DataInProgramm.UserLogin = Login;
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }

        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            string Login = TextBoxUserName.Text;
            string Password = TextBoxPassword.Text;

            if (CheckUser())
            {
                return;
            }
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@Login, @Password)", GetLconnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password;

            LOpenC();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешная регистрация");
            }

            LCloseC();
        }
    }
}
