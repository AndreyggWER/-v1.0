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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
namespace Типа_кликер__v1._0
{
    public partial class Grades_Scoring : Form
    {
        public Grades_Scoring()
        {
            InitializeComponent();
        }
        int total = 0;
        int sum = 0;
        DB db = new DB();
        int y = -74;
        int i = 0;
        int id = -1;
        int Oc(string s)
        {
            int Sum = 0;
            string[] subs = s.Split(' ');
            foreach (var sub in subs)
            {

                string Grade = sub;
                int Koef = 1;

                if (sub.IndexOf("*") > 0)
                {
                    string[] number1 = sub.Split('*');
                    Grade = number1[0];
                    Koef = Convert.ToInt32(number1[1]);
                }

                if (Grade == "5")
                {
                    Sum += 20 * Koef;
                }
                if (Grade == "4")
                {
                    Sum += 4 * Koef;
                }
                if (Grade == "2")
                {
                    Sum -= 100 * Koef;
                }
            }
            total += Sum;
            return Sum;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Name_subject = Convert.ToString(TextBoxNameSubject.Text);
            TextBoxNameSubject.Text = "";
            y += 90;
            i += 1;
            Label labelGenerate = new Label()
            {
                Text = "" + Name_subject,
                Location = new Point(250, y),
                TabIndex = 10,
                Name = "l" + i,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = false,
                Size = new Size(109, 13),};
            Controls.Add(labelGenerate);
            System.Windows.Forms.TextBox textBoxGenerate = new System.Windows.Forms.TextBox()
            {

                Location = new Point(250, y + 18),
                TabIndex = 10,
                Name = "t" + i,};
            Controls.Add(textBoxGenerate);
            Button ButtonGenerate = new Button()
            {
                Text = "подсчитать",
                Location = new Point(250, y + 40),
                TabIndex = 8,
                Name = "b" + i,
            };
            ButtonGenerate.Click += new EventHandler(ButtonGenerate_Click);
            Controls.Add(ButtonGenerate);
        }
        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            id += 1;
            System.Windows.Forms.TextBox chislo = (System.Windows.Forms.TextBox)this.Controls.Find("t" + i, true)[0];
            System.Windows.Forms.Label nadpis = (System.Windows.Forms.Label)this.Controls.Find("l" + i, true)[0];
            db.OpenC();
            MySqlCommand command = new MySqlCommand("INSERT INTO `grades` (`year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES (@year, @quarter, @child, @subject, @grades, @points)", db.getConnection());
            command.Parameters.Add("@year", MySqlDbType.VarChar).Value = TextBoxYear.Text;
            command.Parameters.Add("@quarter", MySqlDbType.VarChar).Value = TextBoxQuart.Text;
            command.Parameters.Add("@child", MySqlDbType.VarChar).Value = TextBoxNameBaby.Text;
            command.Parameters.Add("@subject", MySqlDbType.VarChar).Value = nadpis.Text;
            command.Parameters.Add("@grades", MySqlDbType.VarChar).Value = chislo.Text;
            command.Parameters.Add("@points", MySqlDbType.VarChar).Value = Convert.ToString(Oc(chislo.Text)); ;
            command.ExecuteNonQuery();
        }
    }
}