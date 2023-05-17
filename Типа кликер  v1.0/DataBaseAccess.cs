using System;
using System.Windows.Forms;

namespace Типа_кликер__v1._0
{
    public partial class DataBaseAccess : Form
    {
        public DataBaseAccess()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataInProgramm.DBServer = "server=" + TextBoxServer.Text + ";";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            DataInProgramm.DBPort = "port=" + TextBoxPort.Text + ";";
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            DataInProgramm.DBUserName = "username=" + TextBoxUserName.Text + ";";
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            DataInProgramm.DBPassword = "password=" + TextBoxPassword.Text + ";";

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            DataInProgramm.DataBase = "database=" + TextBoxDataBase.Text + ";";
        }
    }
}
