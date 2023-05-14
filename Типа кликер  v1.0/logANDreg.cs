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

namespace Типа_кликер__v1._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public Boolean CheckUser()
        {
            LDB db = new LDB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SElECT * FROM `users` WHERE `login` = @Login", db.getLconnection());
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
            string Password = TextBoxPassword.Text;

            LDB db = new LDB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SElECT * FROM `users` WHERE `login` = Login AND `password` = Password", db.getLconnection());

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
            LDB db = new LDB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@Login, @Password)", db.getLconnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password;

            db.LOpenC();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешная регистрация");
            }

            db.LCloseC();
        }
    }
}
